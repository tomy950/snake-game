using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    class Snake2 : Settings
    {
        public new static bool GameOver { get; set; }
        public new static int Score { get; set; }
        public new static int direction;

        public override int MakeMove()
        {
            if (Input.KeyPressed(Keys.D))
                direction = 2;
            else if (Input.KeyPressed(Keys.A))
                direction = 3;
            else if (Input.KeyPressed(Keys.W))
                direction = 1;
            else if (Input.KeyPressed(Keys.S))
                direction = 0;

            return direction;
        }
    }
}
