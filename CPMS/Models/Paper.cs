using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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
        public int PaperId { get; set; }


        [Column("AuthorID")]
        public int? AuthorId { get; set; }


        public bool? Active { get; set; }//need to change to checkbox


        [StringLength(100)]
        [Display( Name = "Filename Original")]
        public string FilenameOriginal { get; set; }


        [StringLength(100)]
        public string Filename { get; set; }


        [StringLength(200)]
        public string Title { get; set; }


        [StringLength(3)]
        public string Certification { get; set; }//?


        [Display(Name = "Notes To Reviewers")]
        public string NotesToReviewers { get; set; }//change to bigger box


        [Display(Name = "Analysis of Algorithms")]//checkbox
        public bool? AnalysisOfAlgorithms { get; set; }


        public bool? Applications { get; set; }//checkbox


        public bool? Architecture { get; set; }//checkbox


        [Display(Name = "Artifical Intelligence")]
        public bool? ArtificialIntelligence { get; set; }//checkbox


        [Display(Name = "Computer Engineering")]
        public bool? ComputerEngineering { get; set; }//checkbox


        public bool? Curriculum { get; set; }//?


        [Display(Name = "Data Structures")]//checkbox
        public bool? DataStructures { get; set; }


        public bool? Databases { get; set; }//checkbox
        [Display(Name = "Distance Learning")]


        public bool? DistanceLearning { get; set; }//? CheckBox? is this a subject or saying if you did DL?


        [Display(Name = "Distributed Systems")]//checkbox
        public bool? DistributedSystems { get; set; }


        [Display(Name = "Ethical Societal Issues")]//checkbox
        public bool? EthicalSocietalIssues { get; set; }


        [Display(Name = "First Year Computing")]//checkbox
        public bool? FirstYearComputing { get; set; }
        
        
        [Display(Name = "Gender Issues")]//checkbox
        public bool? GenderIssues { get; set; }


        [Display(Name = "Grant Writing")]//checkbox
        public bool? GrantWriting { get; set; }


        [Display(Name = "Graphics Image Processing")]//checkbox
        public bool? GraphicsImageProcessing { get; set; }


        [Display(Name = "Human Computer Interaction")]//checkbox
        public bool? HumanComputerInteraction { get; set; }


        [Display(Name = "Labortatory Environments")]//checkbox
        public bool? LaboratoryEnvironments { get; set; }
       
        
        public bool? Literacy { get; set; }//?


        [Display(Name = "Mathmetics In Computing")]//checkbox
        public bool? MathematicsInComputing { get; set; }


        public bool? Multimedia { get; set; }//?


        [Display(Name = "Networking Data Communications")]//checkbox
        public bool? NetworkingDataCommunications { get; set; }


        [Display(Name = "Non-Major Courses")]//checkbox
        public bool? NonMajorCourses { get; set; }


        [Display(Name = "Object Oriented Issues")]//checkbox
        public bool? ObjectOrientedIssues { get; set; }


        [Display(Name = "Operating Systems")]//checkbox
        public bool? OperatingSystems { get; set; }


        [Display(Name = "Parallels Processing")]//checkbox
        public bool? ParallelsProcessing { get; set; }


        public bool? Pedagogy { get; set; }//checkbox


        [Display(Name = "Programming Languages")]//checkbox
        public bool? ProgrammingLanguages { get; set; }


        public bool? Research { get; set; }//? Checkbox?


        public bool? Security { get; set; }//checkbox


        [Display(Name = "Software Engineering")]//checkbox
        public bool? SoftwareEngineering { get; set; }


        [Display(Name = "Systems Analysis Design")]//checkbox
        public bool? SystemsAnalysisAndDesign { get; set; }


        [Display(Name = "Using Technology in The Classroom")]//checkbox
        public bool? UsingTechnologyInTheClassroom { get; set; }


        [Display(Name = "Web And Internet Programming")]//checkbox
        public bool WebAndInternetProgramming { get; set; }


        public bool? Other { get; set; }//checkbox
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
