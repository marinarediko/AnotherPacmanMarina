﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotherPacmanMarina
{
    class Hero : PictureBox
    {
        public int Step { get; set; } = 1;
        public int HorVelocity { get; set; } = 0;
        public int VerVelocity { get; set; } = 0;

        public Hero()
        {
            InitializeHero();
        }

        private void InitializeHero()
        {
            this.BackColor = Color.Yellow;
            this.Size = new Size(60, 60);
            this.Location = new Point(200, 200);
            this.Name = "Pacman";
        }


    }
}
