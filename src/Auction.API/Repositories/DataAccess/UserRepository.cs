using Auction.API.Contracts;
using Auction.API.Entities;

namespace Auction.API.Repositories.DataAccess;

public class UserRepository : IUserRepository
{
    private readonly AuctionDbContext _dbContext;
    public UserRepository(AuctionDbContext dbContext) => _dbContext = dbContext;

    public bool ExistUserWithEmail(string email)
    {
        return _dbContext.Users.Any(user => user.Email == email);
    }

    public User GetUserByEmail(string email) => _dbContext.Users.First(user => user.Email.Equals(email));
}
