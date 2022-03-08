namespace OBForum.Models
{
    public class Recognition
    {
        public int RecognitionId { get; set; }
        public bool Success { get; set; }
        public ICollection<Answers>? Answer { get; set; }
        public ICollection<Questions>? Question { get; set; }

    }
}
