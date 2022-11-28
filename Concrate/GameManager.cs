using Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Entity;

namespace Concrate
{
    public class GameManager:IGameServices
    {
        public List<Game> games = new List<Game>();
        public void Add(Game game)
        {
           games.Add(game);
        }

        public void Update(int id,decimal price)
        {
            foreach (var item in games.Where(item => item.GameId==id))
            {
                item.GamePrice = price;
            }
        }

        public void Delete(int id)
        {
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].GameId== id)
                {
                    games.Remove(games[i]);
                }
            }
        }

        public List<Game> GetAllGames()
        {
            return games;
        }
    }
}
