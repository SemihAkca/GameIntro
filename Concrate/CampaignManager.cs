using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;
using Entity;

namespace Concrate
{
    public class CampaignManager : ICampaigService
    {
        readonly IGameServices _gameServices;
        private List<Game> _campaigngames;
        public CampaignManager(IGameServices gameServices)
        {
            _gameServices = gameServices;
            _campaigngames = new List<Game>();
        }

        public void Add(int id,int discount)
        {
            foreach (var item in _gameServices.GetAllGames().Where(g => g.GameId == id))
            {
                item.GamePrice = item.GamePrice * (100 - discount) / 100;
                _campaigngames.Add(item);
            }
        }

        public void Update(int id, int discount)
        {
            for (var i = 0; i < _campaigngames.Count; i++)
            {
                if (_campaigngames[i].GameId != id) continue;
                _campaigngames.Remove(_campaigngames[i]);
                foreach (var result in _gameServices.GetAllGames().Where(result => result.GameId == id))
                {
                    result.GamePrice = result.GamePrice * (100 - discount) / 100;
                    _campaigngames.Add(result);
                }
            }
        }

        public void Delete(int id)
        {
            foreach (var item in _campaigngames.Where(g => g.GameId == id))
            {
                _campaigngames.Remove(item);
            }
        }

        public List<Game> GetCampaignGames()
        {
            return _campaigngames;
        }
    }
}
