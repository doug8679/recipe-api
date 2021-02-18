using System;
using Newtonsoft.Json;
using NUnit.Framework;

namespace recipe.common.test
{
    public class RecipeTests
    {
        private Recipe recipe;

        [SetUp]
        public void Setup()
        {
            recipe = new Recipe { RecipeId = Guid.NewGuid(), Name = "Test Recipe" };
        }

        [Test]
        public void CheckRecipeSerializationResults()
        {
            var json = JsonConvert.SerializeObject(recipe);

            Assert.IsTrue(json.Contains("recipe-id", StringComparison.InvariantCulture));
            Assert.IsTrue(json.Contains("name", StringComparison.InvariantCulture));
            Assert.IsTrue(json.Contains(recipe.RecipeId.ToString()));
            Assert.IsTrue(json.Contains(recipe.Name));
        }

        [Test]
        public void DoesNewRecipeContainValidGuid()
        {
            var rec = new Recipe();

            Assert.AreNotEqual(Guid.Empty, rec.RecipeId);
        }
    }
}