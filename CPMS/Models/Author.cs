using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [StringLength(1)]
        [Display(Name = "MI")]
        public string MiddleInitial { get; set; }
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Affiliation { get; set; }
        [StringLength(50)]
        public string Department { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(10)]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        [StringLength(50)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [StringLength(100)]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
        [StringLength(5)]
        public string Password { get; set; }

        [InverseProperty("Author")]
        public virtual ICollection<Paper> Paper { get; set; }
    }
}
