using NUnit.Framework;
using recipe_api.Controllers;

namespace recipe_api.test
{
    public class RecipeControllerTests
    {
        private RecipeController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new RecipeController();
        }

        [Test]
        public void GetRecipesIsNotEmptyCollection()
        {
            var recipes = _controller.Get();
            Assert.IsNotEmpty(recipes);
        }
    }
}