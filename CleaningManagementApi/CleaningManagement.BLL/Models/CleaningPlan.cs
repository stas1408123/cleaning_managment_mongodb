using System;

namespace NiceFactory.BLL.Models
{
    public class CleaningPlan
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public int CustomerId { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
