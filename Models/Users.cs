namespace OBForum.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        // TODO: Crear clases 
        public ICollection<Roles> Roles { get; set; }
        public ICollection<string> Courses { get; set; }
        public ICollection<string> Modules { get; set; }
    }
}
