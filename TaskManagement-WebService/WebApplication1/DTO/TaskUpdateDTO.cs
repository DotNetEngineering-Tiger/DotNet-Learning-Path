using System;
namespace WebApplication1.DTO
{
    public class TaskUpdateDTO
    {
        public string Title { get; set; } // Optional
        public string Description { get; set; } // Optional
        public string Owner { get; set; } // Optional
        public DateTime? BeginDate { get; set; } // Optional
        public DateTime? EndDate { get; set; } // Optional
    }
}

