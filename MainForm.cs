using Breakout;

namespace BreakoutF1
{
    /// <summary>
    /// Az alkalmazás főablaka.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Engedélyezzük az automatikus duplapufferelést, hogy ne villogjon a rajz.
            DoubleBuffered = true;

            // Létrehozzunk az alkalmazás objektumot.
            App.Initialize(this);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App.Instance.NewGame();
        }

        private void pauseGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App.Instance.PauseGame();
        }

        private void continueGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App.Instance.ContinueGame();
        }

        private void endGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App.Instance.EndGame();
        }

        private void almasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
