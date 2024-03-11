
namespace c_sharp_snake
{
    public partial class Snake : Form
    {
        private Panel greenSquare;

        // 0 empty
        // 1 snake
        // 2 apple
        private int[,] gameField;
        
        public Snake()
        {
            InitializeGreenSquare();
            this.KeyDown += MainForm_KeyDown;
            this.KeyPreview = true; // Stellen Sie sicher, dass die Form KeyDown-Events erhält.

            this.gameField = new int[Config.X_CELLS, Config.Y_CELLS];

            // Set the value of all cells to 0 (empty)
            for(int x = 0; x < Config.X_CELLS; x++)
            {
                for(int y = 0; y < Config.Y_CELLS; y++)
                {
                    this.gameField[x,y] = 0;
                }
            }

            // Spawn the snake in the center of the game field
            int snakeHeadX = Config.X_CELLS / 2;
            int snakeHeadY = Config.Y_CELLS / 2;
            gameField[snakeHeadX, snakeHeadY] = 1;
        }

        private void InitializeGreenSquare()
        {
            greenSquare = new Panel
            {
                Size = new Size(50, 50), // Größe des grünen Quadrats
                BackColor = Color.Green // Farbe des Quadrats
            };

            this.Controls.Add(greenSquare);

            greenSquare.Location = new Point((this.ClientSize.Width - greenSquare.Width) / 2,
                                             (this.ClientSize.Height - greenSquare.Height) / 2); // Zentrieren des Quadrats

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    greenSquare.Top -= 10; // Bewegen nach oben
                    break;

                case Keys.S:
                    greenSquare.Top += 10; // Bewegen nach unten
                    break;

                case Keys.A:
                    greenSquare.Left -= 10; // Bewegen nach links
                    break;

                case Keys.D:
                    greenSquare.Left += 10; // Bewegen nach rechts
                    break;
            }
        }

        private void gameTickTimer_Tick(object sender, EventArgs e)
        {

        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Snake());
        }
    }
}
