namespace EfCoreSample
{
    public class Course
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
