using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Snake
{
    public partial class frmSnake : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        private Circle head = new Circle();
        private bool eaten = false;
        private int maxXPos;
        private int maxYPos;
        private SoundPlayer player = new SoundPlayer();
        
        

        public frmSnake()
        {
            InitializeComponent();

            // set settings to default
            new Settings();

            // set backgroundColour in settings
            // so not to get any food by the same colour
            Settings.backgroundColour = pbCanvas.BackColor;

            // get maxX and maxY
            maxXPos = pbCanvas.Size.Width / Settings.Width;
            maxYPos = pbCanvas.Size.Height / Settings.Height;


            // set game speed and start timer
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            // start new game
            StartGame();


        }

        private void StartGame()
        {
            lblGameOver.Visible = false;
            // set settings to default
           
            Snake.Clear();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);

            lblScoreVal.Text = Settings.Score.ToString();
            GenerateFood();
        }

        // place random food objects
        private void GenerateFood()
        {
            
            Random random = new Random();

            Circle possibleFood = new Circle()
            {
                X = random.Next(0, maxXPos),
                Y = random.Next(0, maxYPos),
                colour = Color.FromArgb(150, Color.FromArgb(random.Next(Int32.MaxValue)))
            };

            if (GoodFood(possibleFood))
            {
                food = possibleFood;
            }
            else
            {
                GenerateFood();
            }
        }

        private bool GoodFood(Circle possibleFood)
        {
            bool boolio = true;
            if (DetectCollision(possibleFood, true))
            {
                boolio = false;
            }
            if (Math.Abs(food.colour.ToArgb() - Settings.backgroundColour.ToArgb()) <= 10500)
            {
                boolio = false;
            }
            return boolio;
        }

        private void UpdateScreen(object sender, EventArgs args)
        { 
            // check for game over
            if (Settings.currentState==Settings.states.GAMEOVER)
            {
                // check if enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {

                    StartGame();
                }
            }
            else if (Settings.currentState == Settings.states.PAUSED)
            {
                frmSplash._frmSnake.Hide();
                frmSplash.sho
            }
            else
            {
                MoveSnake();
            }

            pbCanvas.Invalidate();
        
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (Settings.currentState == Settings.states.RUNNING )
            {
                // set colour of snake
                Color snakeColour;
                
                // draw snake
                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        snakeColour = head.colour;
                    }
                    else
                    {
                        snakeColour = Settings.snakeBodyColour;

                    }

                    // draw snake
                    canvas.FillEllipse(new SolidBrush(snakeColour),
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height
                                      )
                                    );
                    // draw food
                    canvas.FillEllipse(new SolidBrush(food.colour),
                        new Rectangle(food.X * Settings.Width,
                                      food.Y * Settings.Height,
                                      Settings.Width, Settings.Height
                                      )
                                    );
                }
            }
            else
            {
                string gameOver = "Game over.\n" +
                    "Your final score is: " + Settings.Score + "\n" +
                    "Enter to try again";

                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            
            }
        }

        private void MoveSnake()
        {
            // add a circle to snake if snake has eaten
            if (eaten)
            {
                Snake.Add(new Circle());
                eaten = false;
            }
            for (int i = Snake.Count - 1; i >= 0; i--)
            { 
                // move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    { 
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    
                    }
                }
                else
                {
                    // move body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            
            }

            // detect eat
            if (head.X == food.X && head.Y == food.Y)
            {
                Eat();
            }
            // detect snake warping on itself
            if (DetectCollision(head, false) || DetectOutOfScreen())
            {
                Die();
            }

        
        
        }
        // eat method
        private void Eat() 
        {
            PlaySound(Settings.eatSound);
            eaten = true;
            Settings.snakeBodyColour = food.colour;
            UpdateScore();
            GenerateFood();
        
        }
        // die method
        private void Die()
        {
            Settings.currentState = Settings.states.GAMEOVER;
        }
        // update score
        private void UpdateScore()
        {
            Settings.Score += Settings.Points;
            lblScoreVal.Text = Settings.Score.ToString();
        
        }

        private bool DetectCollision(Circle probe, bool headIncluded){
            bool boolio = false;
            List<Circle> target = Snake.GetRange(headIncluded ? 0 : 1, headIncluded ? Snake.Count : Snake.Count-1);
            
            foreach(Circle circle in target)
            {
                if(probe.X == circle.X && probe.Y == circle.Y)
                {
                    boolio = true;
                }
            }

            return boolio;
        }
        
        private bool DetectOutOfScreen()
        {
            bool boolio = false;
            if (
                head.X < 0 ||
                head.Y < 0 ||
                head.X ==  maxXPos ||
                head.Y == maxYPos
                )
            {
                boolio = true;
            }

            return boolio;
        }

        private void PlaySound(System.IO.Stream  audio)
        {
            player.Stream = audio;
            player.Play();
        }

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Right:
                    if(Settings.direction != Direction.Left)
                    {
                        Settings.direction = Direction.Right;
                    };
                    break;
                case Keys.Left:
                    if(Settings.direction != Direction.Right)
                    {
                        Settings.direction = Direction.Left;
                    };
                    break;
                case Keys.Up:
                    if(Settings.direction != Direction.Down)
                    {
                        Settings.direction = Direction.Up;
                    };
                    break;
                case Keys.Down:
                    if(Settings.direction != Direction.Up)
                    {
                        Settings.direction = Direction.Down;
                    };
                    break;
            }
        }           
            
        private void frmSnake_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void frmSnake_Load(object sender, EventArgs e)
        {

        }
    }
}
