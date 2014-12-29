namespace ForumSystem.Data.Models
{
    using ForumSystem.Data.Common.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            // Hack for preventing UserManager.CreateAsync exception
            this.CreatedOn = DateTime.Now;
        }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool PreserveCreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
