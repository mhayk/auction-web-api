using System.ComponentModel.DataAnnotations.Schema;

namespace Auction.API.Entities;

public class AuctionEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Starts { get; set; }
    public DateTime Ends { get; set; }
    
    [ForeignKey("AuctionId")]
    public List<Item> Items { get; set; } = [];

}
