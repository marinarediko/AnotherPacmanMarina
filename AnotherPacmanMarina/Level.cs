using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotherPacmanMarina
{
    class Level : PictureBox
    {
        public Level()
        {
            InitializeLevel();
        }

        public void InitializeLevel()
        {
            this.BackColor = Color.DodgerBlue;
            this.Size = new Size(400, 400);
            this.Location = new Point(100, 100);
            this.Name = "Level";

        }
    }
}
