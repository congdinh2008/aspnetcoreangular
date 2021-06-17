using System;

namespace BookStore.Models
{
    public class Entity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset InsertedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }
    }
}
