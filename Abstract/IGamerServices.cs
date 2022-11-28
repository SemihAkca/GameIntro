using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Abstract
{
    public interface IGamerServices
    {
        void Add(Gamer gamer);
        void Update(string nationalityId,string firstName,string lastName);
        void Delete(Gamer gamer);
        List<Gamer> getGamers();
    }
}
