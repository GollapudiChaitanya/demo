using Demo_Project_Game_Events.Models;

namespace Demo_Project_Game_Events.Repositories
{
    public class GameRepository
    {
        GameEventDbContext ctx = null;
        public GameRepository(GameEventDbContext ctx)
        {            this.ctx = ctx;
        }

        public bool AddGame(Game game)
        {
            ctx.Games.Add(game);
            int r = ctx.SaveChanges();
            if (r > 0)
                return true;
            else
                return false;
        }

        public bool RemoveGame(Game game)
        {
            ctx.Games.Remove(game);
            int r = ctx.SaveChanges();
            if (r > 0)
                return true;
            else
                return false;
        }

        public bool UpdateGame(Game game)
        {
            Game avGame = ctx.Games.Find(game.GameId);
            avGame.GameName = game.GameName;
            avGame.GameType = game.GameType;
            int r = ctx.SaveChanges();
            if (r > 0)
                return true;
            else
                return false;
        }

        public Game SearchGame(int gameId)
        {
            return ctx.Games.Find(gameId);
        }

        public List<Game> AllGameDetails()
        {
            return ctx.Games.ToList();
        }
    }
}
