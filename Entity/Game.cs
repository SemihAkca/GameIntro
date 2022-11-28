using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Game
    {
        public int GameId { get; set; }    
        public string GameName { get; set; }
        public decimal GamePrice { get; set; }

        public Game(int id,string name, decimal price)
        {
            GameId = id;
            GameName = name;
            GamePrice = price;
        }

        public override string ToString()
        {
            return $"{GameId} {GameName} {GamePrice}";
        }
    }
}
