using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class DestructibleForce : MovingObject // [ Task 10 ]
    {
        public DestructibleForce(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { ' ' } }, new MatrixCoords(0, 0))
        {
        }

        public override void Update()
        {
            this.IsDestroyed = true;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block";
        }
    }
}
