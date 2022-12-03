
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using TaskRubicon.Controllers;
using TaskRubicon.Dtos.BlogPostDtos;
using TaskRubicon.Services.BlogPostService;

namespace TaskRubiconTest
{
    public class BlogPostTests
    {
        private readonly IBlogPostService _blogPostService;

        public BlogPostTests()
        {
            _blogPostService = A.Fake<IBlogPostService>();
        }
        [Fact]
        public void BlogPostController_GetAllBlogPosts_ReturnOK()
        {
            string tag = "Postman";
            var controller = new BlogPostController(_blogPostService);

            var result = controller.Get(tag);
            Assert.NotNull(result);
            Assert.IsType<Task<IActionResult>>(result);
            Assert.True(result.IsCompletedSuccessfully);

        }

        [Fact]
        public void BlogPostController_GetBlogPostBySlug_ReturnOK()
        {
            
            var controller = new BlogPostController(_blogPostService);


            var result = controller.GetSingle("java-application");
            Assert.NotNull(result);
            Assert.IsType<Task<IActionResult>>(result);
            Assert.True(result.IsCompletedSuccessfully);

        }

        [Fact]
        public void BlogPostController_AddBlogPost_ReturnOK()
        {

            var controller = new BlogPostController(_blogPostService);

            var model = new AddBlogPostDto
            {
                Title = "Test application",
                Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                Body = "The app is simple to use, and will help you decide on your best furniture fit."
            };
            var result = controller.Add(model);
            Assert.NotNull(result);
            Assert.IsType<Task<IActionResult>>(result);
            Assert.True(result.IsCompletedSuccessfully);
            

        }
    }
}