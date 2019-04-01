using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace EfCoreSample
{
    partial class Program 
    {
        static void Main(string[] args)
        {
            //AddPerson();
            //UseLazyLoading();
            //UseQuerySet();
            using (Context context = new Context())
            {
                var person = context.people.ToList();
            }
            Console.ReadLine();
        }

        private static void UseQuerySet()
        {
            using (Context context = new Context())
            {
                var person = context.PersonDto.FromSql<PersonDto>("SELECT Id, FirstName + ' ' +LastName AS FullName FROM dbo.people");
            }
        }

        private static void UseLazyLoading()
        {
            using (Context context = new Context())
            {
                foreach (var person in context.people)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName}");
                    if (person.courses != null)
                    {
                        foreach (var course in person.courses)
                            Console.WriteLine($"{course.Name}");
                    }
                    else
                        Console.WriteLine("There is No Data");
                }
            }
        }

        private static void AddPerson()
        {
            using (Context context = new Context())
            {
                //context.people.Add(new Person
                //{
                //    Address = new Address { City = "قم", AddressLine = "", Tel = "0935" },
                //    FirstName = "A2",
                //    LastName = "Ahmadi"
                //});
                context.SaveChanges();
            }
        }
    }
}
