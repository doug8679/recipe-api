using System;
using System.Runtime.Serialization;

namespace recipe.common
{
    [DataContract]
    public class Recipe
    {
        public Recipe()
        {
            RecipeId = Guid.NewGuid();
        }

        [DataMember(Name = "recipe-id")]
        public Guid RecipeId { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
