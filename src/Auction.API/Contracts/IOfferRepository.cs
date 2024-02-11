using Auction.API.Entities;

namespace Auction.API.Contracts;

public interface IOfferRepository
{
    void Add(Offer offer);
}
