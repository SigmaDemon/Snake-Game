using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    // This declaration provides the movement of the snake when playing
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    class Settings
    {
        // These are the variables for the game settings declared before being used
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }
        public static Direction Direction { get; internal set; }

        // This method will provide the global settings for the game
        public Settings()
        {
            Width = 16;
            Height = 16;
            Speed = 16;
            Score = 0;
            Points = 100;
            GameOver = false;
            direction = Direction.Down;

        }
    }
}
