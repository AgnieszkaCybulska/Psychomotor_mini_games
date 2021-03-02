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
    public partial class Game1 : Form
    {
        public Game1(Menu m)
        {
            InitializeComponent();
            menu = m;
            timer1.Start();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Button[] buttons = {this.button1, this.button2, this.button3, this.button4, this.button5,
                                    this.button6, this.button7, this.button8, this.button9, this.button10,
                                    this.button11, this.button12, this.button13, this.button14, this.button15,
                                    this.button16, this.button17, this.button18, this.button19, this.button20 };

            if(button.BackColor == Color.YellowGreen)
            {
                Random random = new Random();
                buttons[previouslyRandomIndex].BackColor = Color.Black;
                do
                {
                    randomIndex = random.Next(20);
                } while (randomIndex == previouslyRandomIndex);
                previouslyRandomIndex = randomIndex;

                for (int i = 0; i < buttons.Length; i++)
                {
                    if (i == randomIndex)
                    {
                        buttons[i].BackColor = Color.YellowGreen;
                    }
                }
                if (counter >= 10)
                {
                    timer1.Stop();
                    end_label.Text = "TIME:\n" + time_counter + "ms";
                    end_pictureBox.Visible = end_pictureBox.Enabled = end_label.Visible = exit_game.Enabled = exit_game.Visible = true;
                }
                counter++;
            }
        }

        private void exit_game_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Visible = menu.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_counter += 50;
            time_counter_label.Text = time_counter + "ms";
        }

        private void Game1_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Visible = menu.Enabled = true;
        }
    }
}
