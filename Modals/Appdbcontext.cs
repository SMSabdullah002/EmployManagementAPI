using EmloyManagement.modal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Modals
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options)
       : base(options)
        {
        }
        public DbSet<Employ> Employ { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Employ>().HasData(new Employ
            {
                EmployID = 1,
                FirstName = "John",
                LastName = "Smith",
                Email = "John.smith@gmail.com",
                Gender = Gender.Male,

            });

            modelBuilder.Entity<Employ>().HasData(new Employ
            {
                EmployID = 2,
                FirstName = "Joe",
                LastName = "Gabrial",
                Email = "Joe1987@gmail.com",
                Gender = Gender.Male,

            });

            modelBuilder.Entity<Employ>().HasData(new Employ
            {
                EmployID = 3,
                FirstName = "Will",
                LastName = "Hamster",
                Email = "StrangerThings234@gmail.com",
                Gender = Gender.Male,

            });

            modelBuilder.Entity<Employ>().HasData(new Employ
            {
                EmployID = 4,
                FirstName = "shela",
                LastName = "Barber",
                Email = "Shela.Bhabi@gmail.com",
                Gender = Gender.Female,

            });
        }

    }
}
