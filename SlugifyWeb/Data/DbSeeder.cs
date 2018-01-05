using SlugifyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlugifyWeb.Data
{
    public class DbSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            var blogOne = new Blog { Title = "A blog on programming" };
            context.Blogs.Add(blogOne);

            var coolPost = new Post { Blog = blogOne, Title = "small CAPS @ 123-!!! works" };
            context.Posts.Add(coolPost);

            var blogTwo = new Blog { Title = "Giraffes and lions" };
            context.Blogs.Add(blogTwo);

            var giraffePost = new Post { Blog = blogTwo, Title = "A Giraffe looked at me" };
            context.Posts.Add(giraffePost);

            context.SaveChanges();
        }
    }
}
