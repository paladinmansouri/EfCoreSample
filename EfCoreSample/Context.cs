using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace EfCoreSample
{
    public class Context : DbContext
    {
        public DbSet<Person> people { get; set; } 
        public DbSet<Course> courses { get; set; }
        public DbQuery<PersonDto> PersonDto { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Server=.;Initial Catalog=EfCoreSample;Trusted_Connection=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(new Person
            {
                FirstName = "Atiyeh",
                LastName = "Ahmadi",
                Id = 1,
                // courses = new List<Course> { new Course { Name = "فیزیک هسته ای" }, new Course { Name = "اختر فیزیک" } }
            }, new Person
            {
                FirstName = "Hosein",
                LastName = "Mansouri",
                Id = 2
            });

            modelBuilder.Entity<Course>().HasData(
                new List<Course> { new Course {id= 1, Name = "فیزیک هسته ای", PersonId = 1 },
                new Course {id=2, Name = "اختر فیزیک", PersonId = 1 } });
            modelBuilder.Entity<Person>().Property(x => x.Address)
                .HasConversion(x => JsonConvert.SerializeObject(x),
                x => JsonConvert.DeserializeObject<Address>(x));
            base.OnModelCreating(modelBuilder);
        }
        
    }

}
