using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Abstract
{
    public interface IGamerCheckServices
    {
        bool IfIRealGamer(Gamer gamer);
    }
}
