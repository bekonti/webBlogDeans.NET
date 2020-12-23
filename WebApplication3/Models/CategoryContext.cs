using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication3.Models
{
    public class CategoryContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }

    public class BlogDbInitializer : DropCreateDatabaseAlways<CategoryContext>
    {
        protected override void Seed(CategoryContext db)
        {
            db.Blogs.Add(new Blog { Title = "here is Title 0 ", Content = "here is a Content not a Title 0 ", Author_id=1,PubDate=DateTime.UtcNow });
            db.Blogs.Add(new Blog { Title = "here is Title 1 ", Content = "here is a Content not a Title 1 ", Author_id = 1, PubDate = DateTime.UtcNow });
            db.Blogs.Add(new Blog { Title = "here is Title 2 ", Content = "here is a Content not a Title 2 ", Author_id = 1, PubDate = DateTime.UtcNow });
            base.Seed(db);
        }
    }
}