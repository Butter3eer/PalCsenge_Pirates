using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    internal class Ship
    {
        private List<Pirate> crew = new List<Pirate>();

        static Random rand = new Random();

        public void fillShip()
        {
            Pirate captain = new Pirate();

            for (int i = 0; i < rand.Next(1,3); i++)
            {
                captain.drinkSomeRum();
            }

            this.crew.Add(captain);

            for (int i = 0; i < 111; i++)
            {
                Pirate pirate = new Pirate();

                int random = rand.Next(1,3);

                if (random == 1)
                {
                    pirate.die();
                }

                this.crew.Add(pirate);
            }
        }

        public int aliveCrew(Ship ship)
        {
            int db = 0;

            for (int i = 0; i < ship.crew.Count; i++)
            {
                if (ship.crew[i].Alive)
                {
                    db++;
                }
            }

            return db;
        }

        public bool battle(Ship anothership)
        {
            int score1 = aliveCrew(this) - this.crew[0].Drank;
            int score2 = aliveCrew(anothership) - anothership.crew[0].Drank;

            if (score1 > score2)
            {
                foreach (Pirate pirate in this.crew)
                {
                    Random rndSzam = new Random();
                    int randomSzam = rndSzam.Next(1, 3);

                    for (int i = 0;i < randomSzam; i++)
                    {
                        pirate.Drank++;
                    }
                }

                Random rnd = new Random();
                int random = rnd.Next(0, 30);

                for (int i = 0; i < random; i++)
                {
                    anothership.crew[i].die();
                }

                return true;
            }
            else
            {
                foreach (Pirate pirate in anothership.crew)
                {
                    Random rndSzam = new Random();
                    int randomSzam = rndSzam.Next(1, 3);

                    for (int i = 0; i < randomSzam; i++)
                    {
                        pirate.Drank++;
                    }
                }

                Random rnd = new Random();
                int random = rnd.Next(0, 30);

                for (int i = 0; i < random; i++)
                {
                    this.crew[i].die();
                }

                return false;
            }
        }

        internal List<Pirate> Crew { get => crew; set => crew = value; }

        public override string ToString()
        {
            drawing();
            if (this.crew[0].Alive)
            {
                return $"\n{crew[0].Drank} rum drank the captain and he is alive. Number of alive crew members: {aliveCrew(this)}";
            }
            else
            {
                return $"{crew[0].Drank} rum drank the captain and he is not alive. Number of alive crew members: {aliveCrew(this)}";
            }
            
        }

        public void drawing()
        {
            Console.WriteLine(@"         _ _
                                      __|_|___
                                ____/   ______  \____
                                \   |  |       |  |  /
                                 \  |__|_______|__| /");
        }
    }
}
