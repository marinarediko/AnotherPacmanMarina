using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotherPacmanMarina
{
    public partial class Game : Form
    {
        private Level level = new Level();
        private Hero hero = new Hero();

        private Timer mainTimer = null;

        public Game()
        {
            InitializeComponent();
            InitializeGame();
            InitializeMainTimer();
        }

        public void InitializeGame()
        {
            this.Size = new Size(600, 600);
            // adding level to the game
            this.Controls.Add(level);
            //adding hero
            this.Controls.Add(hero);
            hero.BringToFront();

        }

        private void InitializeMainTimer()
        {
            mainTimer = new Timer();
            mainTimer.Interval = 20;
            mainTimer.Start();
            mainTimer.Tick += MainTimer_Tick;
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            hero.Left += hero.HorVelocity;
            hero.Top += hero.VerVelocity;


        }


    }
}
