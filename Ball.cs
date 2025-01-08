using System.Drawing;

namespace Breakout
{
    /// <summary>
    /// Egy labdát reprezentál.
    /// </summary>
    public class Ball
    {
        /// <summary>
        /// A labda sugara.
        /// </summary>
        int radius = 5;
        /// <summary>
        /// A labda közepének aktuális pozíciója a játéktéren.
        /// </summary>
        Point location;
        /// <summary>
        /// A labda sebességvektorának x összetevője.
        /// </summary>
        int deltaX = 5;
        /// <summary>
        /// A labda sebességvektorának y összetevője.
        /// </summary>
        int deltaY = 5;

        /// <summary>
        /// A labda közepének aktuális pozíciója a játéktéren.
        /// </summary>
        public Point Location
        {
            get { return location; }
        }

        /// <summary>
        /// Lépteti a labdát a játéktéren belül.
        /// </summary>
        /// <param name="batX">Az ütő bal szélének x koordinátája.</param>
        /// <param name="batWidth">Az utő szélessége.</param>
        /// <returns>Igazzal tér vissza, ha a labda eltalálta az ütőt.</returns>
        public bool Iterate(int batX, int batWidth)
        {
            location.X += deltaX;
            location.Y += deltaY;

            if (location.X-radius < 0)
            {
                deltaX *= -1;
                location.X = -(location.X - radius);
            }
            if (location.X+radius > Game.GameArea.Width)
            {
                deltaX *= -1;
                location.X = Game.GameArea.Width - (location.X + radius - Game.GameArea.Width);
            }
            if (location.Y-radius < 0)
            {
                deltaY*= -1;
                location.Y = -(location.Y - radius);
            }

            // Vizsgáljuk meg, eltaláljuk-e az ütőt.
            int batTop = Game.GameArea.Height - 10;
            // Az ütőről visszapattanó labda eseténke kezelése (fordulás és return true)
            if(location.Y == (batTop+radius) && location.X >= batX - ((int)batWidth / 2) && location.X <= batX + ((int)batWidth / 2))
            {
                deltaY *= -1;
                return true;
            }
            
            return false;
        }

        /// <summary>
        /// Kirajzolja a labdát az adott Graphics objektumra.
        /// </summary>
        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Blue, Location.X - radius, Location.Y - radius, 2 * radius, 2 * radius);
        }
    }
}

