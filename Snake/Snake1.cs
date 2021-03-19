using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    class Snake1:Settings
    {
        public new static bool GameOver { get; set; }
        public new static int Score { get; set; }
        public new static int direction;

        public override int MakeMove()
        {
            if (Input.KeyPressed(Keys.Right))
                direction = 2;
            else if (Input.KeyPressed(Keys.Left))
                direction = 3;
            else if (Input.KeyPressed(Keys.Up))
                direction = 1;
            else if (Input.KeyPressed(Keys.Down))
                direction = 0;

            return direction;
        }
    }
}
