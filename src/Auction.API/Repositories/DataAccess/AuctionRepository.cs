using Auction.API.Contracts;
using Auction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auction.API.Repositories.DataAccess;

public class AuctionRepository : IAuctionRepository
{
    private readonly AuctionDbContext _dbContext;
    public AuctionRepository(AuctionDbContext dbContext) => _dbContext = dbContext;
    
    public AuctionEntity? GetCurrent()
    {
        var today = DateTime.Now;

        return _dbContext
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => auction.Starts <= today && auction.Ends >= today);
    }
}
