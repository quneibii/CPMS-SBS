using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

//All the data fields to submit a new author
namespace CPMS.Models
{
    public class Author
    {
        public Author()
        {
            Paper = new HashSet<Paper>();
        }

        [Key]
        [Column("AuthorID")]
        public int AuthorId { get; set; }

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

        [StringLength(100)]
        [Required]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [StringLength(5)]
        [Required]
        public string Password { get; set; }

        [InverseProperty("Author")]
        public virtual ICollection<Paper> Paper { get; set; }
    }
}
