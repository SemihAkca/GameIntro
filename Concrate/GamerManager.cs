using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;
using Entity;

namespace Concrate
{
    public class GamerManager:GamerServices,IGamerServices
    {
        List<Gamer> gamer_list = new List<Gamer>();
        public void Add(Gamer gamer)
        {
            if (IfIRealGamer(gamer)) 
            {
                Console.WriteLine("Added to {0}",gamer.FirstName);
                gamer_list.Add(gamer);
            }
            else
            {
                throw new Exception($"Invalid Gamer {gamer.FirstName}");
            }
        }

        public void Update(string nationalityId,string firstName,string lastName)
        {
            foreach (var gamer in gamer_list.Where(gamer => gamer.NationalityId==nationalityId))
            {
                gamer.FirstName = firstName;
                gamer.LastName = lastName;
                Console.WriteLine("Updated");
            }
        }
        public void Delete(Gamer gamer)
        {
            gamer_list.Remove(gamer);
            Console.WriteLine("{0} 's record deleted", gamer.FirstName);
        }

        public List<Gamer> getGamers()
        {
            return gamer_list;
        }
    }
}
