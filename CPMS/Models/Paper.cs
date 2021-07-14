using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable


//Setup for paper Class to submit paper and inormation about the paper.
namespace CPMS.Models
{
    public partial class Paper
    {
        public Paper()
        {
            Review = new HashSet<Review>();
        }

        [Key]
        [Column("PaperID")]
        [Required]
        public int PaperId { get; set; }


        [Column("AuthorID")]
        [Required]
        public int? AuthorId { get; set; }

        [Required]
        public bool Active { get; set; }


        [StringLength(100)]
        [Required]
        [Display( Name = "Filename Original")]
        public string FilenameOriginal { get; set; }


        [StringLength(100)]
        [Required]
        public string Filename { get; set; }


        [StringLength(200)]
        [Required]
        public string Title { get; set; }


        [StringLength(3)]
        public string Certification { get; set; }


        [Display(Name = "Notes To Reviewers")]
        public string NotesToReviewers { get; set; }


        [Display(Name = "Analysis of Algorithms")]
        public bool AnalysisOfAlgorithms { get; set; }


        public bool Applications { get; set; }


        public bool Architecture { get; set; }


        [Display(Name = "Artifical Intelligence")]
        public bool ArtificialIntelligence { get; set; }


        [Display(Name = "Computer Engineering")]
        public bool ComputerEngineering { get; set; }


        public bool Curriculum { get; set; }


        [Display(Name = "Data Structures")]
        public bool DataStructures { get; set; }


        public bool Databases { get; set; }
        
        
        [Display(Name = "Distance Learning")]
        public bool DistanceLearning { get; set; }


        [Display(Name = "Distributed Systems")]
        public bool DistributedSystems { get; set; }


        [Display(Name = "Ethical Societal Issues")]
        public bool EthicalSocietalIssues { get; set; }


        [Display(Name = "First Year Computing")]
        public bool FirstYearComputing { get; set; }
        
        
        [Display(Name = "Gender Issues")]
        public bool GenderIssues { get; set; }


        [Display(Name = "Grant Writing")]
        public bool GrantWriting { get; set; }


        [Display(Name = "Graphics Image Processing")]
        public bool GraphicsImageProcessing { get; set; }


        [Display(Name = "Human Computer Interaction")]
        public bool HumanComputerInteraction { get; set; }


        [Display(Name = "Labortatory Environments")]
        public bool LaboratoryEnvironments { get; set; }
       
        
        public bool Literacy { get; set; }//?


        [Display(Name = "Mathmetics In Computing")]
        public bool MathematicsInComputing { get; set; }


        public bool Multimedia { get; set; }//?


        [Display(Name = "Networking Data Communications")]
        public bool NetworkingDataCommunications { get; set; }


        [Display(Name = "Non-Major Courses")]
        public bool NonMajorCourses { get; set; }


        [Display(Name = "Object Oriented Issues")]
        public bool ObjectOrientedIssues { get; set; }


        [Display(Name = "Operating Systems")]
        public bool OperatingSystems { get; set; }


        [Display(Name = "Parallels Processing")]
        public bool ParallelsProcessing { get; set; }


        public bool Pedagogy { get; set; }


        [Display(Name = "Programming Languages")]
        public bool ProgrammingLanguages { get; set; }


        public bool Research { get; set; }


        public bool Security { get; set; }


        [Display(Name = "Software Engineering")]
        public bool SoftwareEngineering { get; set; }


        [Display(Name = "Systems Analysis Design")]
        public bool SystemsAnalysisAndDesign { get; set; }


        [Display(Name = "Using Technology in The Classroom")]
        public bool UsingTechnologyInTheClassroom { get; set; }


        [Display(Name = "Web And Internet Programming")]
        public bool WebAndInternetProgramming { get; set; }


        public bool Other { get; set; }
        [StringLength(50)]
        [Display(Name = "Other Description")]
        public string OtherDescription { get; set; }


        [ForeignKey(nameof(AuthorId))]
        [InverseProperty("Paper")]
        public virtual Author Author { get; set; }
        [InverseProperty("Paper")]
        public virtual ICollection<Review> Review { get; set; }
    }
}
