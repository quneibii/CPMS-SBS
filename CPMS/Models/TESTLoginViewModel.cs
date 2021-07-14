using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CPMS.Models
{
    public class TESTLoginViewModel
    {
        #region Properties  
 
        [Required]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        #endregion
    }
}
