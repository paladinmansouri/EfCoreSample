using System.Collections.Generic;

namespace EfCoreSample
{
    public class Person
    {        
        public Person()
        {

        }
        public Person(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        
        public virtual IEnumerable<Course> courses { get; set; }
    }

    public class PersonDto
    {
        public int id { get; set; }
        public string FullName { get; set; }       
    }
}
