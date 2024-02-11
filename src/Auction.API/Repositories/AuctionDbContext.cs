using Auction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auction.API.Repositories;

public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions options) : base(options) { }
    public DbSet<AuctionEntity> Auctions { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Offer> Offers { get; set; } = null!;
}
