using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class GameSettings
    {
        private int gameFieldHeight;

        public GameSettings(int gameFieldHeight, int gameFieldWidth, int creatureLength, int foodAmountOnScreen)
        {

        }

        public int GameFieldHeight 
        { 
            get
            {
                return this.gameFieldHeight;
            }
            private set
            {
                if (value >= 19)
                {
                    this.gameFieldHeight = value;
                }
                else
                {
                    this.gameFieldHeight = 19;
                }
            }
        }
    }
}
