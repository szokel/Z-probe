using System;
using System.Linq;

namespace EFGetStarted
{
    internal class Program
    {
        private static void Main()
        {
            using (var db = new BloggingContext())
            {
                // Note: This sample requires the database to be created before running.

				var blog = new Blog { Url = "http://blogs.msdn.com/adonet" };
                // Create
                Console.WriteLine("Inserting a new blog");
                db.Add(blog);
                db.SaveChanges();

                // Read
                // Console.WriteLine("Querying for a blog");
                // var blog = db.Blogs
                //     .OrderBy(b => b.BlogId)
                //     .First();

                // Update
                Console.WriteLine($"Updating the blog {blog.BlogId} and adding a post");
                blog.Url = "https://devblogs.microsoft.com/dotnet";
                blog.Posts.Add(
                    new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
                db.SaveChanges();
                blog.Posts.Add(
                    new Post { Title = "Hello World 2", Content = "2 I wrote an app using EF Core!" });
                blog.Posts.Add(
                    new Post { Title = "Hello World 3", Content = "3 I wrote an app using EF Core!" });
                db.SaveChanges();

				var blog2 = new Blog{ BlogId = 6};
                db.Remove(blog2);
				try
				{
                	db.SaveChanges();
				}
				catch (Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException ex)
				{
					Console.WriteLine($"DbUpdateConcurrencyException");	
					foreach (var entry in ex.Entries)
					{
						Console.WriteLine($"Hello...");	
					}
				}

                // Delete
                Console.WriteLine("Delete the blog");
                db.Remove(blog);
                db.SaveChanges();
            }
        }
    }
}