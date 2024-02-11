using Auction.API.Communication.Requests;
using Auction.API.Filters;
using Auction.API.UseCases.Offers.CreateOffer;
using Microsoft.AspNetCore.Mvc;

namespace Auction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : AuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateAuction(
        [FromRoute]int itemId,
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);

        return Created(string.Empty, id);
    }
}
