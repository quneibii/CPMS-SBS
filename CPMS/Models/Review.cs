using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CPMS.Models
{
    public partial class Review
    {
        [Key]
        [Column("ReviewID")]
        public int ReviewId { get; set; }
        [Column("PaperID")]
        public int? PaperId { get; set; }
        [Column("ReviewerID")]
        public int? ReviewerId { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        [Display(Name = "Appropriateness of Topic")]
        public decimal? AppropriatenessOfTopic { get; set; }
        [Display(Name = "Timeliness of Topic")]
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? TimelinessOfTopic { get; set; }
        [Display(Name = "Supportive Evidence")]

        [Column(TypeName = "decimal(3, 2)")]
        public decimal? SupportiveEvidence { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        [Display(Name = "Technical Quality")]

        public decimal? TechnicalQuality { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        [Display(Name = "Scope of Coverage")]
public decimal? ScopeOfCoverage { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        [Display(Name = "Citation of Previous Work")]
        public decimal? CitationOfPreviousWork { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? Originality { get; set; }
        [Display(Name = "Content Comments")]
        public string ContentComments { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        [Display(Name = "Organization of Paper")]
        public decimal? OrganizationOfPaper { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        [Display(Name = "Clarity of Main Message")]
        public decimal? ClarityOfMainMessage { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? Mechanics { get; set; }
        [Display(Name = "Written Documents Comments")]
        public string WrittenDocumentComments { get; set; }
        [Display(Name = "Sustainibility For Presentation")]
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? SuitabilityForPresentation { get; set; }
        [Display(Name = "Potential Interest in Topic")]
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? PotentialInterestInTopic { get; set; }
        [Display(Name = "Potential For Oral Presentation Comments")]
        public string PotentialForOralPresentationComments { get; set; }
        [Display(Name = "Overall Rating")]
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? OverallRating { get; set; }
        [Display(Name = "Overall Rating Comments")]
        public string OverallRatingComments { get; set; }
        [Display(Name = "Comfort Level Topic")]
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? ComfortLevelTopic { get; set; }
        [Display(Name = "Comfort Level Acceptability")]
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? ComfortLevelAcceptability { get; set; }
        public bool? Complete { get; set; }

        [ForeignKey(nameof(PaperId))]
        [InverseProperty("Review")]
        public virtual Paper Paper { get; set; }
        [ForeignKey(nameof(ReviewerId))]
        [InverseProperty("Review")]
        public virtual Reviewer Reviewer { get; set; }
    }
}
