namespace ForumSystem.Data.Models
{
    using ForumSystem.Data.Common.Models;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Post : AuditInfo, IDeletableEntity
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string SomeShit { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
