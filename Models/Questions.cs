namespace OBForum.Models
{
    public class Questions
    {
        public int QuestionsId { get; set; }
        public string QuestionsTitle { get; set; }
        public string QuestionDescription { get; set; }
        public string QuestionText { get; set; }

        public Users CreatedBy { get; set; }
        public ICollection<Recognition>? Likes { get; set; }
    }
}
