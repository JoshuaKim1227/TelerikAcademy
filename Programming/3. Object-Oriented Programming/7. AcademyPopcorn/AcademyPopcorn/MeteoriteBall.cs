using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class MeteoriteBall : Ball // [ Task 6 ]
    {
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return false;
        }

        public override IEnumerable<GameObject> ProduceObjects() // [ Task 8 ]
        {
            List<TrailObject> trailObjects = new List<TrailObject>();
            trailObjects.Add(new TrailObject(new MatrixCoords(topLeft.Row, topLeft.Col), new char[,] { { '*' } }, 3));

            return trailObjects;
        }
    }
}
