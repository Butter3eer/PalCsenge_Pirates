using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    internal class Pirate
    {
        private int toxicated = 0;
        private int drank = 0;
        private bool alive = true;

        public void drinkSomeRum()
        {
            if (!alive)
            {
                Console.WriteLine("He's dead.");
            }
            else
            {
                toxicated++;
                drank++;
            } 
        }

        public void howsItGoingMate()
        {

            if (toxicated < 4)
            {
                Console.WriteLine("Pour me anudder!");
            }
            else if (!alive)
            {
                Console.WriteLine("He's dead.");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                toxicated = 0;
            }
        }

        public void brawl(Pirate pirate)
        {
            Random random = new Random();
            int esely = random.Next(0, 3);

            if (alive && pirate.alive)
            {
                if (esely == 0)
                {
                    Console.WriteLine("Argh! *dies*");
                    die();
                }
                else if (esely == 1)
                {
                    Console.WriteLine("Argh! *wins and other dies*");
                    pirate.die();
                }
                else
                {
                    Console.WriteLine("They both passed out.");
                }
            }
            else if (!alive)
            {
                Console.WriteLine("He's dead.");
            }
        }

        public void die()
        {
            alive = false;
        }

        public void Parrot()
        {
            Console.WriteLine("I'm a Parrot!");
        }

        public int Toxicated { get => toxicated; set => toxicated = value; }
        public bool Alive { get => alive; set => alive = value; }
        public int Drank { get => drank; set => drank = value; }
    }
}
