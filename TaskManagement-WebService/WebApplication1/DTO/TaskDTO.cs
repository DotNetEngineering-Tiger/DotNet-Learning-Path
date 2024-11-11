using System;
namespace WebApplication1.DTO
{
    public class TaskDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; } // User ID or name
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; } // ToDo, Doing, Review, Done
        public DateTime CreatedDate { get; set; }
    }
}

