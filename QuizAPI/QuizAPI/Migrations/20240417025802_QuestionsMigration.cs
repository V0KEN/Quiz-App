using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizAPI.Migrations
{
    /// <inheritdoc />
    public partial class QuestionsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    ParticipantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    TimeTaken = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.ParticipantId);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QnInWords = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Option1 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Option2 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Option3 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Option4 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Answer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QnId);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QnId", "Answer", "ImageName", "Option1", "Option2", "Option3", "Option4", "QnInWords" },
                values: new object[,]
                {
                    { 1, 1, null, "Service", "Structure", "Science", "Sub-category", "In the programming world, the acronym SaaS stands for 'software as a' WHAT?" },
                    { 2, 3, null, "HyperTextMarkupLanguage", "JavaScript", "Java", "Pyhton", "What is the programming language developed by James Gosling at Sun Microsystems and named after the type of coffee from Indonesia?" },
                    { 3, 3, null, "MacOS", "Microsoft", "Linux", "Windows", "What popular operating system, launched in 1991, also has its own mascot, Tux the penguin?" },
                    { 4, 2, null, "Compile time Overriding", "Function Overloading", "Compile time Overloading", "Run time Overriding", "The method with the same name or different return type and difference in the parameters either in number or type is known as?" },
                    { 5, 4, null, "Encapsulation", "Overriding", "Polymorphism", "Inheritance", "The process by which one object can acquire the properties of another object:" },
                    { 6, 3, null, "To build a user interface", "Free memory", "Initialize a newly created object", "To create a sub-class", "Constructors are used to:" },
                    { 7, 1, null, "Polymorphism", "Inheritance", "Abstract class", "Interface", "An object that has more than one form is referred to as:" },
                    { 8, 1, null, "Dynamic binding", "Dynamic allocation", "Static typing", "Static allocation", "Pick the term that relates to polymorphism:" },
                    { 9, 2, null, "Using", "Super", "Is-a", "Has-a", "The keyword that is used to access the method or member variables from the superclass:" },
                    { 10, 3, null, "Model", "Properties", "Controller", "View", "Web API, an object that handles HTTP requests is known as a" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
