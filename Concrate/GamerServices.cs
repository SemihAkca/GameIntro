using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;
using Entity;

namespace Concrate
{
    public class GamerServices:IGamerCheckServices
    { 
        List<Gamer> data_gamers = new List<Gamer>()
        {
            new Gamer(1, "Hakan", "Karlı", "12345", new DateTime(2004, 6, 3)),
            new Gamer(2, "Fatma", "Çal", "78963", new DateTime(2003, 4, 12)),
            new Gamer(3, "Aslı", "Duru", "45632", new DateTime(1990, 7, 25)),
            new Gamer(4, "Fırat", "Tepe", "85241", new DateTime(2000, 8, 25)),
        };

        public bool IfIRealGamer(Gamer gamer)
        {
            bool result = false;
            foreach (var item in data_gamers)
            {
                if (item.FirstName == gamer.FirstName && item.LastName == gamer.LastName &&
                    item.DateOfBirth.Year == gamer.DateOfBirth.Year &&
                    item.NationalityId == gamer.NationalityId)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
