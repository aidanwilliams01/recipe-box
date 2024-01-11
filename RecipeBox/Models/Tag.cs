using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Tag
  {
    public string Name { get; set; }
    public int TagId { get; set; }
    public List<RecipeTag> JoinEntities { get; }
  }
}