using System.ComponentModel.DataAnnotations;

namespace Gregslist.models 
{
  public class House {
    public int Id {get; set;} 
    [Required]
    public int price{ get; set; }
    public int bedrooms{ get; set; }
    public int bathrooms{ get; set; }
    public int levels{ get; set; }
    public string description{ get; set; }
    public string img{ get; set; }
    
  }
}