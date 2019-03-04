namespace StudentAPI.Migrations
{
    using StudentAPI.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentAPI.Models.StudentAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StudentAPI.Models.StudentAPIContext context)
        {
            
        }
    }
}
