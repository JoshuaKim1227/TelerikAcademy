using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ShootingRacket : Racket
    {
        private bool GiftTaken = false;
        private bool isShooting = false;

        public ShootingRacket(MatrixCoords topLeft, int width)
            : base(topLeft, width)
        {
        }

        public void Shoot()
        {
            isShooting = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (GiftTaken && isShooting)
            {
                List<Bullet> bullet = new List<Bullet>();
                bullet.Add(new Bullet(new MatrixCoords(topLeft.Row, topLeft.Col + (Width / 2))));

                isShooting = false;

                return bullet;
            }
            else
            {
                return new List<GameObject>();
            }
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            if (collisionData.hitObjectsCollisionGroupStrings.Contains("gift"))
            {
                GiftTaken = true;
            }
        }
    }
}