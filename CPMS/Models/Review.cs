using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

//Setup for Review Class, dealing with ratings and reviews of papers.
namespace CPMS.Models
{
    public partial class Review
    {
        [Key]
        [Column("ReviewID")]
        [Required]
        public int ReviewId { get; set; }


        [Column("PaperID")]
        [Required]
        public int? PaperId { get; set; }


        [Column("ReviewerID")]
        [Required]
        public int? ReviewerId { get; set; }


        [Column(TypeName = "decimal(3, 2)")]
        [Display(Name = "Appropriateness of Topic")]
        [Required]
        public decimal? AppropriatenessOfTopic { get; set; }


        [Display(Name = "Timeliness of Topic")]
        [Column(TypeName = "decimal(3, 2)")]
        [Required]
        public decimal? TimelinessOfTopic { get; set; }


        [Display(Name = "Supportive Evidence")]
        [Column(TypeName = "decimal(3, 2)")]
        [Required]
        public decimal? SupportiveEvidence { get; set; }


        [Column(TypeName = "decimal(3, 2)")]
        [Display(Name = "Technical Quality")]
        [Required]
        public decimal? TechnicalQuality { get; set; }


        [Column(TypeName = "decimal(3, 2)")]
        [Display(Name = "Scope of Coverage")]
        [Required]
        public decimal? ScopeOfCoverage { get; set; }


        [Column(TypeName = "decimal(3, 2)")]
        [Display(Name = "Citation of Previous Work")]
        [Required]
        public decimal? CitationOfPreviousWork { get; set; }


        [Column(TypeName = "decimal(3, 2)")]
        [Required]
        public decimal? Originality { get; set; }


        [Display(Name = "Content Comments")]
        [Required]
        public string ContentComments { get; set; }


        [Column(TypeName = "decimal(3, 2)")]
        [Display(Name = "Organization of Paper")]
        [Required]
        public decimal? OrganizationOfPaper { get; set; }


        [Column(TypeName = "decimal(3, 2)")]
        [Display(Name = "Clarity of Main Message")]
        [Required]
        public decimal? ClarityOfMainMessage { get; set; }


        [Column(TypeName = "decimal(3, 2)")]
        [Required]
        public decimal? Mechanics { get; set; }


        [Display(Name = "Written Documents Comments")]
        [Required]
        public string WrittenDocumentComments { get; set; }


        [Display(Name = "Sustainibility For Presentation")]
        [Column(TypeName = "decimal(3, 2)")]
        [Required]
        public decimal? SuitabilityForPresentation { get; set; }


        [Display(Name = "Potential Interest in Topic")]
        [Column(TypeName = "decimal(3, 2)")]
        [Required]
        public decimal? PotentialInterestInTopic { get; set; }


        [Display(Name = "Potential For Oral Presentation Comments")]
        [Required]
        public string PotentialForOralPresentationComments { get; set; }


        [Display(Name = "Overall Rating")]
        [Column(TypeName = "decimal(3, 2)")]
        [Required]
        public decimal? OverallRating { get; set; }


        [Display(Name = "Overall Rating Comments")]
        [Required]
        public string OverallRatingComments { get; set; }


        [Display(Name = "Comfort Level Topic")]
        [Column(TypeName = "decimal(3, 2)")]
        [Required]
        public decimal? ComfortLevelTopic { get; set; }


        [Display(Name = "Comfort Level Acceptability")]
        [Column(TypeName = "decimal(3, 2)")]
        [Required]
        public decimal? ComfortLevelAcceptability { get; set; }


        [Required]
        public bool Complete { get; set; }

        [ForeignKey(nameof(PaperId))]
        [InverseProperty("Review")]
        public virtual Paper Paper { get; set; }
        [ForeignKey(nameof(ReviewerId))]
        [InverseProperty("Review")]
        public virtual Reviewer Reviewer { get; set; }
    }
}
