
namespace c_sharp_snake
{
    public partial class Snake : Form
    {
        private Panel greenSquare;

        public Snake()
        {
            InitializeGreenSquare();
            this.KeyDown += MainForm_KeyDown;
            this.KeyPreview = true; // Stellen Sie sicher, dass die Form KeyDown-Events erhält.
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

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Snake());
        }
    }
}
