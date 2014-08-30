using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class GiftBlock : Block
    {
        public GiftBlock(MatrixCoords topLeft)
            : base(topLeft)
        {

        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.IsDestroyed)
            {
                List<Gift> gift = new List<Gift>();

                gift.Add(new Gift(new MatrixCoords(this.topLeft.Row, this.topLeft.Col)));

                return gift;
            }
            else
            {
                return new List<GameObject>();
            }
        }
    }
}
