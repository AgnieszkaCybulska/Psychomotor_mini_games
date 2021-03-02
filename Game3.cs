using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_games
{
    public partial class Game3 : Form
    {
        public Game3(Menu m)
        {
            InitializeComponent();
            menu = m;
            Button[] buttons_table = {this.button1,this.button2, this.button3, this.button4, this.button5, this.button6, this.button7, this.button8, this.button9, this.button10,
                                this.button11, this.button12, this.button13,this.button14, this.button15, this.button16,this.button17, this.button18, this.button19,
                                this.button20, this.button21, this.button22,this.button23, this.button24, this.button25,this.button26, this.button27, this.button28,
                                this.button29, this.button30, this.button31,this.button32, this.button33, this.button34,this.button35, this.button36, this.button37,
                                this.button38, this.button39, this.button40,this.button41, this.button42, this.button43,this.button44, this.button45, this.button46,
                                this.button47, this.button48, this.button49,this.button50};
            buttons = buttons_table;
            timer1.Start();
            random_location();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((sound == true && button.Text == "😀") || (sound == false && button.Text == "😥"))
            {
                if (counter >= 7)
                {
                    timer1.Stop();
                    end_label.Text = "TIME:\n" + timerCounter + "ms";
                    end_pictureBox.Visible = end_pictureBox.Enabled = end_label.Visible = exit_button.Enabled = exit_button.Visible = true;
                }
                counter++;
                random_location();
            }
        }

        private void random_location()
        {
            SoundPlayer happy_sound = new SoundPlayer(Mini_games.Properties.Resources.happy);
            SoundPlayer sad_sound = new SoundPlayer(Mini_games.Properties.Resources.sad);
            SoundPlayer[] sounds_table = { happy_sound, sad_sound };

            Random random = new Random();
            randomIndexColor = random.Next(colors.Length);
            randomIndexFace = random.Next(buttons.Length);
            randomIndexSound = random.Next(sounds_table.Length);

            sounds_table[randomIndexSound].Play();

            switch (randomIndexSound)
            {
                case 0:
                    sound = true;
                    break;
                case 1:
                    sound = false;
                    break;
            }

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = "😐";
                randomIndexColor = random.Next(colors.Length);
                buttons[i].ForeColor = colors[randomIndexColor];
                if (randomIndexFace == i)
                {
                    if (sound)
                    {
                        buttons[i].Text = "😀";
                    }
                    else
                    {
                        buttons[i].Text = "😥";
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCounter += 50;
            timer_counter_label.Text = timerCounter + "ms";
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Visible = menu.Enabled = true;
        }

        private void Game3_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Visible = menu.Enabled = true;
        }
    }
}
