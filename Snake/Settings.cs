using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Snake
{
    public enum Direction 
    { 
        Up,
        Down,
        Left,
        Right
    }
    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static Direction direction { get; set; }
        public static Stream eatSound { get; set; }
        public static Color snakeBodyColour { get; set; }
        public static Color backgroundColour { get; set; }
        public static int playerVolume { get; set; }
        public enum states{
            PAUSED,
            GAMEOVER,
            RUNNING
        }
        public static states currentState;
        

        public Settings()
        {
            Width = 16;
            Height = 16;
            Speed = 16;
            Score = 0;
            Points = 100;
            direction = Direction.Down;
            eatSound = Properties.Resources.eat;
            snakeBodyColour = Color.FromArgb(0);
            playerVolume = 60;
            currentState = states.PAUSED;

        }

    }
}
