using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_games
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game1 = new Game1(this);
            game1.Show();
            this.Visible = this.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game2 = new Game2(this);
            game2.Show();
            this.Visible = this.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game3 = new Game3(this);
            game3.Show();
            this.Visible = this.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game4 = new Game4(this);
            game4.Show();
            this.Visible = this.Enabled = false;
        }
    }
}
