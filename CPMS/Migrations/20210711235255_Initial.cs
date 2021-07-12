using Microsoft.EntityFrameworkCore.Migrations;

namespace CPMS.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    MiddleInitial = table.Column<string>(maxLength: 1, nullable: true, defaultValueSql: "('')"),
                    LastName = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    Affiliation = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    Department = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    Address = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    City = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    State = table.Column<string>(maxLength: 2, nullable: true, defaultValueSql: "('')"),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "('')"),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    EmailAddress = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "('')"),
                    Password = table.Column<string>(maxLength: 5, nullable: true, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "Defaults",
                columns: table => new
                {
                    EnabledReviewers = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    EnabledAuthors = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Reviewer",
                columns: table => new
                {
                    ReviewerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    MiddleInitial = table.Column<string>(maxLength: 1, nullable: true, defaultValueSql: "('')"),
                    LastName = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    Affiliation = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    Department = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    Address = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    City = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    State = table.Column<string>(maxLength: 2, nullable: true, defaultValueSql: "('')"),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "('')"),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    EmailAddress = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "('')"),
                    Password = table.Column<string>(maxLength: 5, nullable: true, defaultValueSql: "('')"),
                    AnalysisOfAlgorithms = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Applications = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Architecture = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    ArtificialIntelligence = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    ComputerEngineering = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Curriculum = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    DataStructures = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Databases = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    DistancedLearning = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    DistributedSystems = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    EthicalSocietalIssues = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    FirstYearComputing = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    GenderIssues = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    GrantWriting = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    GraphicsImageProcessing = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    HumanComputerInteraction = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    LaboratoryEnvironments = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Literacy = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    MathematicsInComputing = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Multimedia = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    NetworkingDataCommunications = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    NonMajorCourses = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    ObjectOrientedIssues = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    OperatingSystems = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    ParallelProcessing = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Pedagogy = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    ProgrammingLanguages = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Research = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Security = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    SoftwareEngineering = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    SystemsAnalysisAndDesign = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    UsingTechnologyInTheClassroom = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    WebAndInternetProgramming = table.Column<bool>(nullable: false),
                    Other = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    OtherDescription = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    ReviewsAcknowledged = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviewer", x => x.ReviewerID);
                });

            migrationBuilder.CreateTable(
                name: "Paper",
                columns: table => new
                {
                    PaperID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorID = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
                    FilenameOriginal = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "('')"),
                    Filename = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "('')"),
                    Title = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "('')"),
                    Certification = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "('')"),
                    NotesToReviewers = table.Column<string>(nullable: true, defaultValueSql: "('')"),
                    AnalysisOfAlgorithms = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Applications = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Architecture = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    ArtificialIntelligence = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    ComputerEngineering = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Curriculum = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    DataStructures = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Databases = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    DistanceLearning = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    DistributedSystems = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    EthicalSocietalIssues = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    FirstYearComputing = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    GenderIssues = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    GrantWriting = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    GraphicsImageProcessing = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    HumanComputerInteraction = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    LaboratoryEnvironments = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Literacy = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    MathematicsInComputing = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Multimedia = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    NetworkingDataCommunications = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    NonMajorCourses = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    ObjectOrientedIssues = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    OperatingSystems = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    ParallelsProcessing = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Pedagogy = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    ProgrammingLanguages = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Research = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Security = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    SoftwareEngineering = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    SystemsAnalysisAndDesign = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    UsingTechnologyInTheClassroom = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    WebAndInternetProgramming = table.Column<bool>(nullable: false),
                    Other = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    OtherDescription = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paper", x => x.PaperID);
                    table.ForeignKey(
                        name: "FK_Paper_Author",
                        column: x => x.AuthorID,
                        principalTable: "Author",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaperID = table.Column<int>(nullable: true),
                    ReviewerID = table.Column<int>(nullable: true),
                    AppropriatenessOfTopic = table.Column<decimal>(type: "decimal(3, 2)", nullable: true, defaultValueSql: "((0))"),
                    TimelinessOfTopic = table.Column<decimal>(type: "decimal(3, 2)", nullable: true, defaultValueSql: "((0))"),
                    SupportiveEvidence = table.Column<decimal>(type: "decimal(3, 2)", nullable: true, defaultValueSql: "((0))"),
                    TechnicalQuality = table.Column<decimal>(type: "decimal(3, 2)", nullable: true, defaultValueSql: "((0))"),
                    ScopeOfCoverage = table.Column<decimal>(type: "decimal(3, 2)", nullable: true, defaultValueSql: "((0))"),
                    CitationOfPreviousWork = table.Column<decimal>(type: "decimal(3, 2)", nullable: true, defaultValueSql: "((0))"),
                    Originality = table.Column<decimal>(type: "decimal(3, 2)", nullable: true, defaultValueSql: "((0))"),
                    ContentComments = table.Column<string>(nullable: true, defaultValueSql: "('')"),
                    OrganizationOfPaper = table.Column<decimal>(type: "decimal(3, 2)", nullable: true, defaultValueSql: "((0))"),
                    ClarityOfMainMessage = table.Column<decimal>(type: "decimal(3, 2)", nullable: true, defaultValueSql: "((0))"),
                    Mechanics = table.Column<decimal>(type: "decimal(3, 2)", nullable: true, defaultValueSql: "((0))"),
                    WrittenDocumentComments = table.Column<string>(nullable: true, defaultValueSql: "('')"),
                    SuitabilityForPresentation = table.Column<decimal>(type: "decimal(3, 2)", nullable: true, defaultValueSql: "((0))"),
                    PotentialInterestInTopic = table.Column<decimal>(type: "decimal(3, 2)", nullable: true, defaultValueSql: "((0))"),
                    PotentialForOralPresentationComments = table.Column<string>(nullable: true, defaultValueSql: "('')"),
                    OverallRating = table.Column<decimal>(type: "decimal(3, 2)", nullable: true, defaultValueSql: "((0))"),
                    OverallRatingComments = table.Column<string>(nullable: true, defaultValueSql: "('')"),
                    ComfortLevelTopic = table.Column<decimal>(type: "decimal(3, 2)", nullable: true, defaultValueSql: "((0))"),
                    ComfortLevelAcceptability = table.Column<decimal>(type: "decimal(3, 2)", nullable: true, defaultValueSql: "((0))"),
                    Complete = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Score_Paper",
                        column: x => x.PaperID,
                        principalTable: "Paper",
                        principalColumn: "PaperID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_Reviewer",
                        column: x => x.ReviewerID,
                        principalTable: "Reviewer",
                        principalColumn: "ReviewerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paper_AuthorID",
                table: "Paper",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_PaperID",
                table: "Review",
                column: "PaperID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_ReviewerID",
                table: "Review",
                column: "ReviewerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Defaults");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Paper");

            migrationBuilder.DropTable(
                name: "Reviewer");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
