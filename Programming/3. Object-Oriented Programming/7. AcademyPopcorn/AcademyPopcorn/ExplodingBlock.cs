using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ExplodingBlock : Block // [ Task 10 ]
    {
        public new const string CollisionGroupString = "explodingBlock";

        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<DestructibleForce> destructibleForces = new List<DestructibleForce>();

            if (this.IsDestroyed)
            {
                destructibleForces.Add(new DestructibleForce(new MatrixCoords(this.topLeft.Row - 1, this.topLeft.Col - 1)));
                destructibleForces.Add(new DestructibleForce(new MatrixCoords(this.topLeft.Row - 1, this.topLeft.Col)));
                destructibleForces.Add(new DestructibleForce(new MatrixCoords(this.topLeft.Row - 1, this.topLeft.Col + 1)));

                destructibleForces.Add(new DestructibleForce(new MatrixCoords(this.topLeft.Row, this.topLeft.Col - 1)));
                destructibleForces.Add(new DestructibleForce(new MatrixCoords(this.topLeft.Row, this.topLeft.Col + 1)));

                destructibleForces.Add(new DestructibleForce(new MatrixCoords(this.topLeft.Row + 1, this.topLeft.Col - 1)));
                destructibleForces.Add(new DestructibleForce(new MatrixCoords(this.topLeft.Row + 1, this.topLeft.Col)));
                destructibleForces.Add(new DestructibleForce(new MatrixCoords(this.topLeft.Row + 1, this.topLeft.Col + 1)));

                return destructibleForces;
            }
            else
            {
                return destructibleForces;
            }
        }
    }
}
