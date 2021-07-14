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

            
        }

        public async Task<IActionResult> OnPost()
        {
            var admin = configuration.GetSection("Admin").Get<Admin>();


            if (Input.Email == admin.EmailAddress && Input.Password == admin.Password)
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
            ErrorMessage = "Invalid attempt";
            return Page();
        }
    }
    
}
