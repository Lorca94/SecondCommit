namespace OBForum.Models
{
    public class Topics
    {
        public int TopicsId { get; set; }
        public string Title { get; set; }
        public string Description {  get; set; }
        public ICollection<Users> Suscriber { get; set; }
        public ICollection<Questions> Question { get; set; }
        public ICollection<Answers>? Answer { get; set; }
    }
}
