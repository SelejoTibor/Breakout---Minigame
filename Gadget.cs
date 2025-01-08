using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Breakout
{
    /// <summary>
    /// Egy a játéktérben lefelé hulló bónusz elemet reprezentál. Minden egyes bónusz típusra 
    /// származtassunk egy új osztályt.
    /// </summary>
    public class Gadget
    {
        /// <summary>
        /// Lépteti a bónuszelemet a játéktéren belül (lefelé mozgatja)
        /// </summary>
        public void Iterate()
        {
            // ...
        }

        /// <summary>
        /// Kirajzolja a bónuszelemet az adott Graphics objektumra.
        /// </summary>
        public void Draw(Graphics g)
        {

        }
    }
}
