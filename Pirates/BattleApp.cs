using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    internal class BattleApp
    {
        public void Main()
        {
            Ship ship1 = new Ship();
            Ship ship2 = new Ship();

            ship1.fillShip();
            ship2.fillShip();

            if(ship1.battle(ship2))
            {
                Console.WriteLine("OOh ship1 nyert!");
            }
            else
            {
                Console.WriteLine("OOh ship2 nyert!");
            }
        }
    }
}
