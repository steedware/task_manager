using System.Collections.Generic;
namespace TaskManagementApp.Models


{


    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Relacja: użytkownik może mieć wiele zadań
        public List<TaskItem> Tasks { get; set; } = new();
    }

}