namespace ForumSystem.Data
{
    using ForumSystem.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}
