using Auction.API.Entities;

namespace Auction.API.Contracts;

public interface IAuctionRepository
{
    AuctionEntity? GetCurrent();
}
