using Auction.API.Entities;

namespace Auction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public AuctionEntity Execute()
    {
        return new AuctionEntity
        {
            Id = 1,
            Name = "Auction 1",
            Starts = DateTime.Now,
            Ends = DateTime.Now.AddDays(7)
        };
    }
}
