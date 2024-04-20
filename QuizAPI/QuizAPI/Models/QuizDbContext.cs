using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QuizAPI.Models
{
    public class QuizDbContext : DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
        { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Participant> Participants { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var question1 = new Question() { QnId = 1, QnInWords = "In the programming world, the acronym SaaS stands for 'software as a' WHAT?", Option1 = "Service", Option2 = "Structure", Option3 = "Science", Option4 = "Sub-category", Answer = 0 };
            var question2 = new Question() { QnId = 2, QnInWords = "What is the programming language developed by James Gosling at Sun Microsystems and named after the type of coffee from Indonesia?", Option1 = "HyperTextMarkupLanguage", Option2 = "JavaScript", Option3 = "Java", Option4 = "Pyhton", Answer = 2 };
            var question3 = new Question() { QnId = 3, QnInWords = "What popular operating system, launched in 1991, also has its own mascot, Tux the penguin?", Option1 = "MacOS", Option2 = "Microsoft", Option3 = "Linux", Option4 = "Windows", Answer = 2 };
            var question4 = new Question() { QnId = 4, QnInWords = "The method with the same name or different return type and difference in the parameters either in number or type is known as?", Option1 = "Compile time Overriding", Option2 = "Function Overloading", Option3 = "Compile time Overloading", Option4 = "Run time Overriding", Answer = 1 };
            var question5 = new Question() { QnId = 5, QnInWords = "The process by which one object can acquire the properties of another object:", Option1 = "Encapsulation", Option2 = "Overriding", Option3 = "Polymorphism", Option4 = "Inheritance", Answer = 3 };
            var question6 = new Question() { QnId = 6, QnInWords = "Constructors are used to:", Option1 = "To build a user interface", Option2 = "Free memory", Option3 = "Initialize a newly created object", Option4 = "To create a sub-class", Answer = 2 };
            var question7 = new Question() { QnId = 7, QnInWords = "An object that has more than one form is referred to as:", Option1 = "Polymorphism", Option2 = "Inheritance", Option3 = "Abstract class", Option4 = "Interface", Answer = 0 };
            var question8 = new Question() { QnId = 8, QnInWords = "Pick the term that relates to polymorphism:", Option1 = "Dynamic binding", Option2 = "Dynamic allocation", Option3 = "Static typing", Option4 = "Static allocation", Answer = 0 };
            var question9 = new Question() { QnId = 9, QnInWords = "The keyword that is used to access the method or member variables from the superclass:", Option1 = "Using", Option2 = "Super", Option3 = "Is-a", Option4 = "Has-a", Answer = 1 };
            var question10 = new Question() { QnId = 10, QnInWords = "Web API, an object that handles HTTP requests is known as a", Option1 = "Model", Option2 = "Properties", Option3 = "Controller", Option4 = "View", Answer = 2 };

            builder.Entity<Question>().HasData(question1, question2, question3, question4, question5, question6, question7, question8, question9, question10);
        }
    }
}