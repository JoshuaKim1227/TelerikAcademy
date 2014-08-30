using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Zombie : Animal, ICarnivore
    {
        public Zombie(string name, Point location)
            : base(name, location, 0)
        {
        }

        public override void Update(int timeElapsed)
        {
            if (this.State == AnimalState.Sleeping)
            {
                if (timeElapsed >= sleepRemaining)
                {
                    this.Awake();
                }
                else
                {
                    this.sleepRemaining -= timeElapsed;
                }
            }

            base.Update(timeElapsed);
        }

        public override int GetMeatFromKillQuantity()
        {
            this.IsAlive = true;

            return 10;
        }

        public int TryEatAnimal(Animal animal)
        {
            return 0;
        }
    }
}