namespace TaskManagementApp.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }

        // Nowe pole klucza obcego
        public int? AssignedUserId { get; set; }
        public User AssignedUser { get; set; }
    }
}
