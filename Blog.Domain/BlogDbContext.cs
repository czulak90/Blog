using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Blog.Domain
{
    public class BlogDbContext : IdentityDbContext<ApplicationUser>
    {
        public BlogDbContext() : base("BlogDbContext")
        {
        }
        public static BlogDbContext Create()
        {
            return new BlogDbContext();
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        
    }
}
