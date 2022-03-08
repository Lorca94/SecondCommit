namespace OBForum.Models
{
    public class Courses
    {
        public int CoursesId { get; set; }
        public string CoursesName { get; set; }
        public ICollection<Users> Suscriber { get; set; }
        public ICollection<Modules>? Module { get; set; }
    }
}
