namespace Snake
{
    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static int direction;

        public  Settings()
        {
            Width = 16;
            Height = 16;
            Speed = 10;
            Score = 0;
            Points = 100;
            GameOver = false;
            direction = 0;
        }

        public virtual int MakeMove()
        {
            return direction = 0;
        }
    }
}
