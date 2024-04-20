﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizAPI.Models;

#nullable disable

namespace QuizAPI.Migrations
{
    [DbContext(typeof(QuizDbContext))]
    [Migration("20240420021702_updatedAnswers")]
    partial class updatedAnswers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuizAPI.Models.Participant", b =>
                {
                    b.Property<int>("ParticipantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParticipantId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("TimeTaken")
                        .HasColumnType("int");

                    b.HasKey("ParticipantId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("QuizAPI.Models.Question", b =>
                {
                    b.Property<int>("QnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QnId"));

                    b.Property<int>("Answer")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Option1")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Option2")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Option3")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Option4")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("QnInWords")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("QnId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QnId = 1,
                            Answer = 0,
                            Option1 = "Service",
                            Option2 = "Structure",
                            Option3 = "Science",
                            Option4 = "Sub-category",
                            QnInWords = "In the programming world, the acronym SaaS stands for 'software as a' WHAT?"
                        },
                        new
                        {
                            QnId = 2,
                            Answer = 2,
                            Option1 = "HyperTextMarkupLanguage",
                            Option2 = "JavaScript",
                            Option3 = "Java",
                            Option4 = "Pyhton",
                            QnInWords = "What is the programming language developed by James Gosling at Sun Microsystems and named after the type of coffee from Indonesia?"
                        },
                        new
                        {
                            QnId = 3,
                            Answer = 2,
                            Option1 = "MacOS",
                            Option2 = "Microsoft",
                            Option3 = "Linux",
                            Option4 = "Windows",
                            QnInWords = "What popular operating system, launched in 1991, also has its own mascot, Tux the penguin?"
                        },
                        new
                        {
                            QnId = 4,
                            Answer = 1,
                            Option1 = "Compile time Overriding",
                            Option2 = "Function Overloading",
                            Option3 = "Compile time Overloading",
                            Option4 = "Run time Overriding",
                            QnInWords = "The method with the same name or different return type and difference in the parameters either in number or type is known as?"
                        },
                        new
                        {
                            QnId = 5,
                            Answer = 3,
                            Option1 = "Encapsulation",
                            Option2 = "Overriding",
                            Option3 = "Polymorphism",
                            Option4 = "Inheritance",
                            QnInWords = "The process by which one object can acquire the properties of another object:"
                        },
                        new
                        {
                            QnId = 6,
                            Answer = 2,
                            Option1 = "To build a user interface",
                            Option2 = "Free memory",
                            Option3 = "Initialize a newly created object",
                            Option4 = "To create a sub-class",
                            QnInWords = "Constructors are used to:"
                        },
                        new
                        {
                            QnId = 7,
                            Answer = 0,
                            Option1 = "Polymorphism",
                            Option2 = "Inheritance",
                            Option3 = "Abstract class",
                            Option4 = "Interface",
                            QnInWords = "An object that has more than one form is referred to as:"
                        },
                        new
                        {
                            QnId = 8,
                            Answer = 0,
                            Option1 = "Dynamic binding",
                            Option2 = "Dynamic allocation",
                            Option3 = "Static typing",
                            Option4 = "Static allocation",
                            QnInWords = "Pick the term that relates to polymorphism:"
                        },
                        new
                        {
                            QnId = 9,
                            Answer = 1,
                            Option1 = "Using",
                            Option2 = "Super",
                            Option3 = "Is-a",
                            Option4 = "Has-a",
                            QnInWords = "The keyword that is used to access the method or member variables from the superclass:"
                        },
                        new
                        {
                            QnId = 10,
                            Answer = 2,
                            Option1 = "Model",
                            Option2 = "Properties",
                            Option3 = "Controller",
                            Option4 = "View",
                            QnInWords = "Web API, an object that handles HTTP requests is known as a"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
