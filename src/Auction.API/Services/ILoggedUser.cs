using Auction.API.Contracts;
using Auction.API.Entities;

namespace Auction.API.Services;

public interface ILoggedUser
{
    User User();
}
