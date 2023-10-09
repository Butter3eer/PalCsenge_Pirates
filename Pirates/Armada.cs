using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    internal class Armada
    {
        private List<Ship> armadaLista = new List<Ship>();

        public bool war(Armada otherArmada)
        { 
            for (int i = 0; i < armadaLista.Count - 1; i++)
            {
                for(int j = 0; j < otherArmada.armadaLista.Count - 1; j++)
                {      
                    if (armadaLista[i].battle(otherArmada.armadaLista[j]))
                    {
                        otherArmada.armadaLista.Remove(otherArmada.armadaLista[j]);
                    }
                    else
                    {
                        armadaLista.Remove(armadaLista[i]);
                    }
                }
            }

            if (armadaLista.Count > otherArmada.armadaLista.Count)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }

        public void armadaFeltolt()
        {
            for (int i = 0; i < 20; i++)
            {
                Ship ship = new Ship();

                ship.fillShip();
                armadaLista.Add(ship);
            }
        }
    }
}
