using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CPMS.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Data;
using System;

namespace CPMS.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {

        private readonly IConfiguration configuration;
        public LoginModel(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [BindProperty]
            public string Role { get; set; }
        }

        public async Task<IActionResult> OnPost()
        {
            // admin login

            var Admin = configuration.GetSection("Admin").Get<Admin>();

            if (Input.Email == Admin.EmailAddress && Input.Password == Admin.Password)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, Input.Email),
                    new Claim(ClaimTypes.Name, "Steve Smith"),
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return RedirectToPage("/Authors/Index");
            }
            string ReviewerLogin = "dbo.spReviewerLogin @EmailAddress,  @Password, @RowCount, @AuthorID, @FirstName, @User";

            SqlParameter EmailParameter = new SqlParameter("@EmailAddress", Input.Email);
            SqlParameter PasswordParameter = new SqlParameter("@Password", Input.Password);
            Author CurrentAuthor = new Author();
            var table = new DataTable();

            string AuthorLogin = "dbo.spAuthorLogin 	@EmailAddress, @Password, @RowCount, @AuthorID, @FirstName, @User";


            using (SqlConnection SqlAuthor = new SqlConnection(configuration.GetConnectionString("CPMS")))
            {
                SqlAuthor.Open();

                using (SqlCommand Command = new SqlCommand(AuthorLogin, SqlAuthor))
                {
                    //Command.CommandType = System.Data.CommandType.StoredProcedure;


                    Command.Parameters.Add(EmailParameter);
                    Command.Parameters.Add(PasswordParameter);
                    Command.Parameters.Add("@RowCount", SqlDbType.Int).Direction = ParameterDirection.Output;
                    Command.Parameters.Add("@AuthorID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    Command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    Command.Parameters.Add("@User", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;

                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            CurrentAuthor.AuthorId = (int)Reader["AuthorID"];
                            CurrentAuthor.FirstName = (string)Reader["FirstName"];
                        }
                    }
                }
                SqlAuthor.Close();

            }


            if (CurrentAuthor.AuthorId > 0)
            {


                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, Input.Email),
                    new Claim(ClaimTypes.Name, CurrentAuthor.FirstName),
                    //new Claim(ClaimTypes.AuthorId, CurrentAuthor.AuthorId),
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return RedirectToPage("/Authors/Index");
            }
            else if (Input.Role == "Reviewer")
            {
                RedirectToPage("/Areas/Identity/Pages/Account/Register");
            }
            ErrorMessage = "Invalid attempt";
            return Page();
        }
    }
    
}
