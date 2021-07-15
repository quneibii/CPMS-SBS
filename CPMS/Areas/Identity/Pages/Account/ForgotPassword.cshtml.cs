using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CPMS.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ForgotPasswordModel : PageModel
    {

        [BindProperty]
        public InputModel Input { get; set; }
        [BindProperty]
        public string Message { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                using (SqlConnection Connection = new SqlConnection("Server=GALAXYBOOK360-S;Database=CPMS;Trusted_Connection=True;MultipleActiveResultSets=true"))
                {
                    string Query = "SELECT Password FROM Author WHERE Email = @EmailAddress";
                    SqlCommand Command = new SqlCommand(Query, Connection);
                    Command.Parameters.AddWithValue("@EmailAddress", Input.Email);
                    Connection.Open();
                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Message = Reader["Password"].ToString();
                        }

                        Connection.Close();
                    }
                }


               // Message = "Success";

                RedirectToPage("./ForgotPasswordConfirmation");

            }

            return Page();
        }
    }
}
