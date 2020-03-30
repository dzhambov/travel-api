using System.Collections.Generic;

namespace TravelAPI.Models
{
  public class Destination
  {
    public int DestinationId { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public int Rating { get; set; }
    public List<Review> Reviews {get;set;}
  }
}