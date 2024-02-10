using Auction.API.Entities;
using Auction.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Auction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public AuctionEntity? Execute()
    {
        var repository = new AuctionDbContext();

        var today = DateTime.Now;


        return repository
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => auction.Starts <= today && auction.Ends >= today);
    }
}
