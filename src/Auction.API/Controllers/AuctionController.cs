using Auction.API.Entities;
using Auction.API.UseCases.Auctions.GetCurrent;
using Microsoft.AspNetCore.Mvc;

namespace Auction.API.Controllers;

public class AuctionController : AuctionBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(AuctionEntity), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction()
    {
        var useCase = new GetCurrentAuctionUseCase();
        
        var result = useCase.Execute();

        if(result == null)
        {
            return NoContent();
        }

        return Ok(result);
    }
}
