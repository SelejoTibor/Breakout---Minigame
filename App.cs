using System.Drawing;
using System.Windows.Forms;

namespace Breakout
{
    /// <summary>
    /// Az alkalmazást reprezentálja. Egy példányt kell létrehozni belőle az Initialize 
    /// hívásával, ez lesz a "gyökérobjektum". Ez bármely osztály számára hozzáférhető az
    /// App.Instance propertyn keresztül.
    /// Jelenleg egy feladata van: menedzseli az aktuális Game objektumot. 
    /// </summary>
    public class App
    {
        /// <summary>
        /// Tárolja az aktuális játék Game objektumát, illetve null, ha nincs futó játék.
        /// </summary>
        private Game currentGame = null;
        /// <summary>
        /// A főablakot tárolja.
        /// </summary>
        private Form mainForm;

        /// <summary>
        /// Az alkalmazásobjektum tárolására szolgál. 
        /// </summary>
        private static App theApp;
        /// <summary>
        /// Elérhetővé teszi mindenki számára az alkalmazásobjektumot (App.Instance-ként
        /// érhető el.)
        /// </summary>
        public static App Instance
        {
            get { return theApp; }
        }
        /// <summary>
        /// Létrehozza az alkalmazásobjektumot.
        /// </summary>
        public static void Initialize(Form form)
        {
            theApp = new App();
            theApp.mainForm = form;
        }

        /// <summary>
        /// Visszaadja azt a control-t, amire a játék rajzolódik. Ez jelen esetben a mainForm.
        /// </summary>
        /// <value>The game panel.</value>
        public Control GamePanel
        {
            get { return mainForm; }            
        }

        /// <summary>
        /// Új játékot indít, ha még nem volt indítva (egyébként figyelmezteti a felhasználót).
        /// </summary>
        public void NewGame()
        {
            if (currentGame != null)
            {
                MessageBox.Show("Game allready started!");
                return;
            }

            currentGame = new Game();
        }

        /// <summary>
        /// Befejezi az aktuális játékot (ha volt).
        /// </summary>
        public void EndGame()
        {
            if (currentGame == null)
                return;

            currentGame.End();
            currentGame = null;
        }

        /// <summary>
        /// Megállítja az aktuális játékot.
        /// </summary>
        public void PauseGame()
        {
            if (currentGame != null)
                currentGame.Pause();
        }

        /// <summary>
        /// Folytatja az aktuális játékot (Pause után).
        /// </summary>
        public void ContinueGame()
        {
            if (currentGame != null)
                currentGame.Continue();
        }
    }
}
