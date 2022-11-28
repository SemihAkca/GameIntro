using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Abstract
{
    public interface ICampaigService
    {
        void Add(int id,int discount);

        void Update(int id, int discount);
        void Delete(int id);
        List<Game> GetCampaignGames();
    }
}
