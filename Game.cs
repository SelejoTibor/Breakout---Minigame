using System.Drawing.Drawing2D;
using Timer = System.Windows.Forms.Timer;

namespace Breakout
{
    /// <summary>
    /// Egy játékot reprezentál. Összefogja a játékelemeket.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// A játéktéren levő labdák listája.
        /// </summary>
        List<Ball> balls = new List<Ball>();
        /// <summary>
        /// A játéktéren levő bónuszelemek listája.
        /// </summary>
        List<Gadget> gadgets = new List<Gadget>();
        /// <summary>
        /// Az ütő.
        /// </summary>
        Bat bat = new Bat();
        /// <summary>
        /// Időzítő, amely lépteti a játékteret.
        /// </summary>
        Timer timer = new Timer();
        /// <summary>
        /// Az aktuális pontszám.
        /// </summary>
        int score = 0;
        /// <summary>
        /// Az aktuális pálya. Nincs kidolgozva.
        /// </summary>
        Level currentLevel;

        /// <summary>
        /// A játéktér méretét adja vissza (ami konstans). Statikus, így
        /// bárhonnan könnyen elhető (Game.GameArea).
        /// </summary>
        public static Size GameArea
        {
            get { return new Size(600, 400); }
        }

        /// <summary>
        /// Az aktuális pontszámot adja vissza.
        /// </summary>
        public int Score
        {
            get { return score; }
        }

        /// <summary>
        /// Megadja, hogy az játék meg van-e állítva.
        /// </summary>
        public bool IsPaused
        {
            get { return timer.Enabled; }
        }

        /// <summary>
        /// Konstruktor. Inicializálja a játékot. El is indítja a játékot (timer).
        /// </summary>
        public Game()
        {
            App.Instance.GamePanel.Paint += new PaintEventHandler(control_Paint);
            App.Instance.GamePanel.MouseMove += new MouseEventHandler(control_MouseMove);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 20;

            balls.Add(new Ball());

            timer.Start();
        }

        /// <summary>
        /// Az újrarajzolás (Paint) eseménykezelője.
        /// </summary>
        void control_Paint(object sender, PaintEventArgs e)
        {
            draw(e.Graphics);
        }

        /// <summary>
        /// Az egérmozgatás (MouseMove) eseménykezelője.
        /// </summary>
        void control_MouseMove(object sender, MouseEventArgs e)
        {
            bat.MoveTo(e.X);
        }

        /// <summary>
        /// Az időzítő eseménykezelője.
        /// </summary>
        void timer_Tick(object sender, EventArgs e)
        {
            iterate();
            App.Instance.GamePanel.Invalidate();
        }

        /// <summary>
        /// Folytatja a játékot Pause után.
        /// </summary>
        public void Continue()
        {
            timer.Start();
        }

        /// <summary>
        /// Megállítja a játékot.
        /// </summary>
        public void Pause()
        {
            timer.Stop();
        }

        /// <summary>
        /// Befejezi a játékot.
        /// </summary>
        public void End()
        {
            timer.Stop();
            timer.Tick -= new EventHandler(timer_Tick);
            App.Instance.GamePanel.Paint -= new PaintEventHandler(control_Paint);
            App.Instance.GamePanel.MouseMove -= new MouseEventHandler(control_MouseMove); // Leiratkozás a mouse move eseményről
            timer.Dispose();
            App.Instance.GamePanel.Invalidate(); // Biztos törlődjön a háttér.
        }

        /// <summary>
        /// Kirajzolja a játék aktuális állását.
        /// </summary>
        /// <param name="g">A Graphics objektum, amire a kirajzolás történik.</param>
        void draw(Graphics g)
        {
            // Háttér kirajzolása mintás ecsettel.
            g.FillRectangle(new HatchBrush(HatchStyle.Wave, Color.Silver, Color.Transparent),
                         0, 0, GameArea.Width, GameArea.Height);

            // Labdák kirajzolása
            foreach (Ball ball in balls)
                ball.Draw(g);
            // Bónuszok kirajzolása
            foreach (Gadget gadget in gadgets)
                gadget.Draw(g);

            // Ütő kirajzolása.
            bat.Draw(g);

            // Pontszám kirajzolása.
            g.DrawString(score.ToString(), new Font(new FontFamily("Arial"), 40), Brushes.Green, 520, 20);
        }

        /// <summary>
        /// Lépteti a játékteret.
        /// </summary>
        void iterate()
        {
            // Labdák léptetése
            foreach (Ball ball in balls)
            {
                if (ball.Iterate(bat.XPos, bat.Width))
                    score++;
                else if (isBallOut(ball))
                {
                    App.Instance.EndGame();
                    MessageBox.Show("Vége!");
                    return;
                }
            }

            // Bónuszok léptetése
            foreach (Gadget gadget in gadgets)
                gadget.Iterate();
        }

        /// <summary>
        /// Megvizsgálja, hogy véget ér-e a játék (elhagyta-e alul az ütő érintése nélkül a
        /// játékteret).
        /// </summary>
        bool isBallOut(Ball ball)
        {
            return ball.Location.Y > GameArea.Height - 10;
        }
    }
}
