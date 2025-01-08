using System.Drawing;

namespace Breakout
{
    /// <summary>
    /// A játékos által mozgatott ütőt reprezentálja.
    /// </summary>
    public class Bat
    {
        /// <summary>
        /// Az ütő bal szélének x koordinátája.
        /// </summary>
        int xPos = 0;
        /// <summary>
        /// Az ütő szélessége.
        /// </summary>
        int width = 40;
        /// <summary>
        /// Az ütő magassága (konstans)
        /// </summary>
        const int height = 10;

        /// <summary>
        ///  Az ütő bal szélének x koordinátája.
        /// </summary>
        public int XPos
        {
            get { return xPos; }
        }
        
        /// <summary>
        /// Az ütő szélessége.
        /// </summary>
        public int Width
        {
            get { return width; }
        }

        /// <summary>
        /// Az ütő mozgatása.
        /// </summary>
        public void MoveTo(int x)
        {
            xPos = x;
        }

        /// <summary>
        /// Az ütő kirajzolása.
        /// </summary>
        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Red, XPos - (int)(width / 2),(int)(Game.GameArea.Height-height/2),width,height);
        }
    }
}
