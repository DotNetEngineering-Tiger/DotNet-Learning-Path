using System;
namespace WebApplication1.DTO
{
    public class TaskCreateDTO
    {
        public string Title { get; set; } // Required
        public string Description { get; set; } // Optional
        public string Owner { get; set; } // User ID or name (Required)
        public DateTime? BeginDate { get; set; } // Optional
        public DateTime? EndDate { get; set; } // Optional
    }
}

