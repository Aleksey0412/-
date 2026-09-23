namespace BlockchainConferenceApp.Models
{
    public class TaskItem
    {
        public int TaskId { get; set; }
        public int ActivityId { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; } = "New";
    }
}