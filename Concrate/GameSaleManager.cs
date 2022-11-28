using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;
using Entity;

namespace Concrate
{
    internal class GameSaleManager:IGameSaleServices
    {
        IGamerServices _gamerServices;

        IGameServices _gameServices;

        private Dictionary<Gamer, Game> _salesList;

        public GameSaleManager(IGamerServices gamerServices,IGameServices gameServices)
        {
            _gamerServices = gamerServices;
            _gameServices = gameServices;
            _salesList = new Dictionary<Gamer, Game>();
        }

        public void Add(Gamer gamer, Game game)
        {
            var gamerToAdd = _gamerServices.getGamers().FirstOrDefault(g => g.Id == gamer.Id);
            var gameToAdd = _gameServices.GetAllGames().FirstOrDefault(g => g.GameId == game.GameId);
            if (gamerToAdd == null) return;
            if (gameToAdd != null)
                _salesList.Add(gamerToAdd, gameToAdd);
        }

        public void Remove(Gamer gamer)
        {
            _salesList.Remove(gamer);
        }

        public Dictionary<Gamer,Game> getSalesList()
        {
            return _salesList;
        }
    }
}
