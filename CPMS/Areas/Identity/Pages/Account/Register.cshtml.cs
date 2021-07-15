using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace CPMS.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(5)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [StringLength(50)]
            [Required]
            [RegularExpression("[A-Za-z]+")]//letters only
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [StringLength(1)]
            [Display(Name = "MI")]
            [RegularExpression("[A-Za-z]+")]//letters only
            public string MiddleInitial { get; set; }

            [StringLength(50)]
            [Required]
            [Display(Name = "Last Name")]
            [RegularExpression("[A-Za-z]+")]//letters only
            public string LastName { get; set; }

            [StringLength(50)]
            [RegularExpression(@"^[a-zA-z0-9\s]*$")]//letters, numbers and space
            public string Affiliation { get; set; }

            [StringLength(50)]
            [RegularExpression(@"^[a-zA-z0-9\s]*$")]//letters, numbers and space
            public string Department { get; set; }

            [StringLength(50)]
            [Required]
            [RegularExpression(@"^[a-zA-Z0-9\s-.]*$")]//letters, space, numbers, and dash
            public string Address { get; set; }

            [StringLength(50)]
            [Required]
            [RegularExpression(@"^[a-zA-z\s]*$")]//letters and space
            public string City { get; set; }

            [StringLength(2)]
            [Required]
            [RegularExpression("[A-Za-z]+")]//letters only
            public string State { get; set; }

            [StringLength(10)]
            [Display(Name = "Zip Code")]
            [RegularExpression(@"^[0-9-]*$")]//numbers and dashes only
            public string ZipCode { get; set; }

            [StringLength(50)]
            [Required]
            [Display(Name = "Phone Number")]
            [RegularExpression(@"^[0-9-()]*$")]//numbers ,dashes, parentheses
            public string PhoneNumber { get; set; }

            [BindProperty]
            public string Role { get; set; }
        }
    }
}
