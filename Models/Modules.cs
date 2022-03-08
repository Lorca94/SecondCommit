namespace OBForum.Models
{
    public class Modules
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public ICollection<Users> Suscriber { get; set; }
    }
}
