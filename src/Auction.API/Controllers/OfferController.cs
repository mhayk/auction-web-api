using Microsoft.AspNetCore.Mvc;

namespace Auction.API.Controllers;

public class OfferController : AuctionBaseController
{
    [HttpPost]
    public IActionResult CreateAuction()
    {
        return Created();
    }
}
