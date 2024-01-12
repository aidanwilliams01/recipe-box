using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public string Title { get; set; }
    public string Ingredients { get; set; }
    public string Instructions { get; set; }
    public int RecipeId { get; set; }
    public List<RecipeTag> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}