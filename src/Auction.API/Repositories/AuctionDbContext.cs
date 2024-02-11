using Auction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auction.API.Repositories;

public class AuctionDbContext : DbContext
{
    public DbSet<AuctionEntity> Auctions { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Offer> Offers { get; set; } = null!;
    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=C:\Users\eu\mhayk\c#-projects\auction-web-api\leilaoDbNLW.db");
    }
}
