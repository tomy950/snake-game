using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Circle> snake1 = new List<Circle>();
        private List<Circle> snake2 = new List<Circle>();
        private Circle food = new Circle();

        public Form1()
        {
            InitializeComponent();

            //Postavljamo vrijednosti na default
            new Settings();
            
            //Postavljamo ispis na labele
            label1.Text = "";
            label1.Text += "PLAYER 1";
            label2.Text = "";
            label2.Text += "PLAYER 2";

            //Set game speed and start timer
            gameTimer1.Interval = 1500 / Settings.Speed;
            gameTimer1.Tick += UpdateScreen1;
            gametimer2.Interval = 1500 / Settings.Speed;
            gametimer2.Tick += UpdateScreen2;
            gameTimer1.Start();
            gametimer2.Start();

            StartGame();
          
        }

        private void StartGame()
        {
            //Set settings to default
            new Settings();

            //Create new player object
            snake1.Clear();
            snake2.Clear();
            Circle head1 = new Circle {X = 5, Y = 10};
            snake1.Add(head1);
            Circle head2 = new Circle { X = 5, Y = 10 };
            snake2.Add(head2);
            GenerateFood(pbCanvas1);
            GenerateFood(pbCanvas2);
        }

        //Place random food object
        private void GenerateFood(PictureBox pb)
        {
            int maxXPos = pb.Size.Width / Settings.Width;
            int maxYPos = pb.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle {X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos)};
        }

        private void UpdateScreen1(object sender, EventArgs e)
        {
            //Check for Game Over
            if (Snake1.GameOver)
            {
                gameTimer1.Stop();
                gametimer2.Stop();
                string gameOver = "\nGame over \nYour final score is: " + Snake2.Score + "\nPress Enter to try again";
                label1.Text = "";
                label1.Text = "PLAYER 1\n" + gameOver;
                Winner();
                //Check if Enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                Snake1 sn1 = new Snake1();
                sn1.MakeMove();
                MovePlayer1();
            }

            pbCanvas1.Invalidate();
        }

        
        private void UpdateScreen2(object sender, EventArgs e)
        {
            //Check for Game Over
            if (Snake2.GameOver)
            {
                gameTimer1.Stop();
                gametimer2.Stop();
                string gameOver = "\nGame over \nYour final score is: " + Snake1.Score + "\nPress Enter to try again";
                label2.Text = "";
                label2.Text = "PLAYER 2\n" + gameOver;
                Winner();
                //Check if Enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                Snake2 sn2 = new Snake2();
                sn2.MakeMove();
                MovePlayer2();
            }

            pbCanvas2.Invalidate();
        }
       

        private void pbCanvas1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Snake1.GameOver)
            {
                //Set colour of snake

                //Draw snake
                for (int i = 0; i < snake1.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Black;     //Draw head
                    else
                        snakeColour = Brushes.Green;    //Rest of body

                    //Draw snake
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(snake1[i].X * Settings.Width,
                                      snake1[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                    //Draw Food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                             food.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }
            else
            {
                string gameOver = "\nGame over \nYour final score is: " + Snake1.Score + "\nPress Enter to try again";
                label2.Text = "";
                label2.Text = "PLAYER 2\n"+ gameOver;
            }
        }
        
        private void pbCanvas2_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Snake2.GameOver)
            {
                //Set colour of snake

                //Draw snake
                for (int i = 0; i < snake2.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Black;     //Draw head
                    else
                        snakeColour = Brushes.Blue;    //Rest of body

                    //Draw snake
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(snake2[i].X * Settings.Width,
                                      snake2[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                    //Draw Food
                    canvas.FillEllipse(Brushes.Yellow,
                        new Rectangle(food.X * Settings.Width,
                             food.Y * Settings.Height, Settings.Width, Settings.Height));

                }
            }
            else
            {
                string gameOver = "\nGame over \nYour final score is: " + Snake2.Score + "\nPress Enter to try again";
                label1.Text = "";
                label1.Text = "PLAYER 1\n" + gameOver;
            }
        }

        private void MovePlayer1()
        {
            for (int i = snake1.Count - 1; i >= 0; i--)
            {
                //Move head
                if (i == 0)
                {

                    if (Snake1.direction == 0)
                    {
                        snake1[i].Y++;
                    }
                    else if (Snake1.direction == 1)
                    {
                        snake1[i].Y--;
                    }
                    else if (Snake1.direction == 2)
                    {
                        snake1[i].X++;
                    }
                    else if (Snake1.direction == 3)
                    {
                        snake1[i].X--;
                    }
                   

                    //Get maximum X and Y Pos
                    int maxXPos = pbCanvas1.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas1.Size.Height / Settings.Height;

                    //Detect collission with game borders.
                    if (snake1[i].X < 0 || snake1[i].Y < 0
                        || snake1[i].X >= maxXPos || snake1[i].Y >= maxYPos)
                    {
                        Snake1.GameOver = true;
                    }


                    //Detect collission with body
                    for (int j = 1; j < snake1.Count; j++)
                    {
                        if (snake1[i].X == snake1[j].X &&
                           snake1[i].Y == snake1[j].Y)
                        {
                            Snake1.GameOver = true;
                        }
                    }

                    //Detect collision with food piece
                    if (snake1[0].X == food.X && snake1[0].Y == food.Y)
                    {
                        //Add circle to body
                        Circle circle = new Circle
                        {
                            X = snake1[snake1.Count - 1].X,
                            Y = snake1[snake1.Count - 1].Y
                        };
                        snake1.Add(circle);

                        //Update Score
                        Snake1.Score += Settings.Points;

                        GenerateFood(pbCanvas1);
                    }

                }
                else
                {
                    //Move body
                    snake1[i].X = snake1[i - 1].X;
                    snake1[i].Y = snake1[i - 1].Y;
                }
            }
        }


        private void MovePlayer2()
        {
            for (int i = snake2.Count - 1; i >= 0; i--)
            {
                //Move head
                if (i == 0)
                {

                    if (Snake2.direction == 0)
                    {
                        snake2[i].Y++;
                    }
                    else if (Snake2.direction == 1)
                    {
                        snake2[i].Y--;
                    }
                    else if (Snake2.direction == 2)
                    {
                        snake2[i].X++;
                    }
                    else if (Snake2.direction == 3)
                    {
                        snake2[i].X--;
                    }

                    //Get maximum X and Y Pos
                    int maxXPos = pbCanvas2.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas2.Size.Height / Settings.Height;

                    //Detect collission with game borders.
                    if (snake2[i].X < 0 || snake2[i].Y < 0
                        || snake2[i].X >= maxXPos || snake2[i].Y >= maxYPos)
                    {
                        Snake2.GameOver = true;
                    }


                    //Detect collission with body
                    for (int j = 1; j < snake2.Count; j++)
                    {
                        if (snake2[i].X == snake2[j].X &&
                           snake2[i].Y == snake2[j].Y)
                        {
                            Snake2.GameOver = true;
                        }
                    }

                    //Detect collision with food piece
                    if (snake2[0].X == food.X && snake2[0].Y == food.Y)
                    {
                        //Add circle to body
                        Circle circle = new Circle
                        {
                            X = snake2[snake2.Count - 1].X,
                            Y = snake2[snake2.Count - 1].Y
                        };
                        snake2.Add(circle);

                        //Update Score
                        Snake2.Score += Settings.Points;
                        GenerateFood(pbCanvas2);
                    }

                }
                else
                {
                    //Move body
                    snake2[i].X = snake2[i - 1].X;
                    snake2[i].Y = snake2[i - 1].Y;
                }
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
        
        private void Winner()
        {
            label3.Visible = true;

            if (Snake1.GameOver)
            {
                label3.Text = "";
                label3.Text = "WINNER IS PLAYER 1";
            }
            else
            {
                label3.Text = "";
                label3.Text = "WINNER IS PLAYER 2";
                
                
            }
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            pbCanvas1.BackColor = Color.SteelBlue;
            pbCanvas2.BackColor = Color.SteelBlue;
            
            
        }
    }
}
