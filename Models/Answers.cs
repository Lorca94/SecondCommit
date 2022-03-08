namespace OBForum.Models
{
    public class Answers
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public Users CreateBy { get; set; }
        public ICollection<Recognition>? Likes { get; set; }
    }
}
