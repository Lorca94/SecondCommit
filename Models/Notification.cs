namespace OBForum.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public ICollection<Topics> Topic { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
