namespace Gregslist.models 
{
  public class Job {
    public int Id { get; set; }
    public string jobTitle { get; set; }
    public string company { get; set; }
    public int rate { get; set; }
    public int hours { get; set; }
    public string description { get; set; }
  }
}