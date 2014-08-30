using System;

namespace AcademyPopcorn
{
    public class ExtendedEngine : Engine // [Task 4] [ Task 13 ]
    {
        public ExtendedEngine(IRenderer renderer, IUserInterface userInterface, int sleepValue)
            : base(renderer, userInterface, sleepValue)
        {
        }

        public void ShootPlayerRacket()
        {
            (this.playerRacket as ShootingRacket).Shoot();
        }
    }
}