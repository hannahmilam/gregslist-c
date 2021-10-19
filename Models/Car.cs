using System.ComponentModel.DataAnnotations;

namespace Gregslist.models 
{
  public class Car
   {
    public int Id {get; set;} 
    
      [Required]
      [MinLength(3)]
    public string make{ get; set; }
    public string model{ get; set; }
    public int year{ get; set; }
    public string description{ get; set; }
    public int price{ get; set; }
    public string img{ get; set; }
    
  }
}