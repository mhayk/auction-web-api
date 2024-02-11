using Auction.API.Contracts;
using Auction.API.Entities;

namespace Auction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    private readonly IAuctionRepository _repository;
    public GetCurrentAuctionUseCase(IAuctionRepository repository) => _repository = repository;
    public AuctionEntity? Execute()
    {
        return _repository.GetCurrent();
    }
}
