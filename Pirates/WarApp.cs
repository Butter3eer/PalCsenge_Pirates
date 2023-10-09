using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    internal class WarApp
    {
        static void Main()
        {
            Armada armada1 = new Armada();
            Armada armada2 = new Armada();

            armada1.armadaFeltolt();
            armada2.armadaFeltolt();

            if (armada1.war(armada2))
            {
                Console.WriteLine("OOh armada1 wins!");
            }
            else
            {
                Console.WriteLine("OOh armada2 wins!");
            }
        }
    }
}
