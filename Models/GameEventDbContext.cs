using Microsoft.EntityFrameworkCore;

namespace Demo_Project_Game_Events.Models
{
    public class GameEventDbContext : DbContext
    {
        public GameEventDbContext(DbContextOptions<GameEventDbContext> options):base(options)
        {
        }

        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<GameEvent> GameEvents { get; set; }
    }
}


