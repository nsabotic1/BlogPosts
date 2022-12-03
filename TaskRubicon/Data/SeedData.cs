using Microsoft.EntityFrameworkCore;
using TaskRubicon.Models;

namespace TaskRubicon.Data
{
    public class SeedData
    {
        public static void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BlogPost>().HasData(new BlogPost
            {
                Id = 1,
                Slug = "augmented-reality-ios-application",
                Title = "Augmented Reality iOS Application",
                Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow,
            });


            modelBuilder.Entity<BlogPost>().HasData(new BlogPost
            {
                Id = 2,
                Slug = "augmented-reality-ios-application-2",
                Title = "Augmented Reality iOS Application 2",
                Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow,
            });


            modelBuilder.Entity<BlogPost>().HasData(new BlogPost
            {
                Id = 3,
                Slug = "java-application",
                Title = "Java application",
                Description = "Rubicon Software Development and Gazzda furniture are proud to launch an java app.",
                Body = "The app is simple to use.",
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow
            });

            modelBuilder.Entity<BlogPost>().HasData(new BlogPost
            {
                Id = 4,
                Slug = "console-application-for-students",
                Title = "Console application for students!",
                Description = "Faculty of Electrical Engineering Sarajevo is proud to launch an console app.",
                Body = "The app is suitable for beginners.",
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow
            });

            modelBuilder.Entity<BlogPost>().HasData(new BlogPost
            {
                Id = 5,
                Slug = "android-application",
                Title = "Android application",
                Description = "A young student is proud to launch an android app.",
                Body = "The app is very interesting.",
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow
            });
            modelBuilder.Entity<Tag>().HasData(
            new Tag { BlogPostId = 1, Id = 1, Title = "iOS" });
            modelBuilder.Entity<Tag>().HasData(
            new Tag { BlogPostId = 1, Id = 2, Title = "AR" });
            modelBuilder.Entity<Tag>().HasData(
            new Tag { BlogPostId = 2, Id = 3, Title = "Gazzda" });
            modelBuilder.Entity<Tag>().HasData(
            new Tag { BlogPostId = 2, Id = 4, Title = "AR" });
            modelBuilder.Entity<Tag>().HasData(
            new Tag { BlogPostId = 2, Id = 5, Title = "iOS" });
            modelBuilder.Entity<Tag>().HasData(
            new Tag { BlogPostId = 3, Id = 6, Title = "Java" });
            modelBuilder.Entity<Tag>().HasData(
            new Tag { BlogPostId = 3, Id = 7, Title = "React" });
            modelBuilder.Entity<Tag>().HasData(
            new Tag { BlogPostId = 4, Id = 8, Title = "React" });
            modelBuilder.Entity<Tag>().HasData(
            new Tag { BlogPostId = 4, Id = 9, Title = "ASP.NET" });
            modelBuilder.Entity<Tag>().HasData(
            new Tag { BlogPostId = 4, Id = 10, Title = "Postman" });
            modelBuilder.Entity<Tag>().HasData(
            new Tag { BlogPostId = 5, Id = 11, Title = "Kotlin" });
            modelBuilder.Entity<Tag>().HasData(
            new Tag { BlogPostId = 5, Id = 12, Title = "Flutter" });
            modelBuilder.Entity<Tag>().HasData(
            new Tag { BlogPostId = 5, Id = 13, Title = "Postman" });

            modelBuilder.Entity<Comment>().HasData(
            new Comment
            {
                BlogPostId = 1,
                Id = 1,
                Body = "Great blog.",
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow
            });

            modelBuilder.Entity<Comment>().HasData(
            new Comment
            {
                BlogPostId = 1,
                Id = 2,
                Body = "Very nice blog",
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow
            });

            modelBuilder.Entity<Comment>().HasData(
            new Comment
            {
                BlogPostId = 1,
                Id = 3,
                Body = "Wonderful blog.",
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow
            });

            modelBuilder.Entity<Comment>().HasData(
            new Comment
            {
                BlogPostId = 2,
                Id = 4,
                Body = "Woow",
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow
            });

            modelBuilder.Entity<Comment>().HasData(
            new Comment
            {
                BlogPostId = 3,
                Id = 5,
                Body = "Amazing",
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow
            });

            modelBuilder.Entity<Comment>().HasData(
             new Comment
             {
                 BlogPostId = 3,
                 Id = 6,
                 Body = "I love it!",
                 createdAt = DateTime.UtcNow,
                 updatedAt = DateTime.UtcNow
             });

            modelBuilder.Entity<Comment>().HasData(
             new Comment
             {
                 BlogPostId = 4,
                 Id = 7,
                 Body = "The best app ever!",
                 createdAt = DateTime.UtcNow,
                 updatedAt = DateTime.UtcNow
             });

            modelBuilder.Entity<Comment>().HasData(
             new Comment
             {
                 BlogPostId = 4,
                 Id = 8,
                 Body = "I don't like it!",
                 createdAt = DateTime.UtcNow,
                 updatedAt = DateTime.UtcNow
             });

            modelBuilder.Entity<Comment>().HasData(
            new Comment
            {
                BlogPostId = 5,
                Id = 9,
                Body = "I don't like it!",
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow
            });

            modelBuilder.Entity<Comment>().HasData(
            new Comment
            {
                BlogPostId = 5,
                Id = 10,
                Body = "One of the best apps i ever had",
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow
            });

        }
    }
}
