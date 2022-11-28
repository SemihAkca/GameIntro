using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Abstract
{
    public interface IGameSaleServices
    {
        void Add(Gamer gamer, Game game);
        void Remove(Gamer gamer);
        Dictionary<Gamer,Game> getSalesList();
    }
}
