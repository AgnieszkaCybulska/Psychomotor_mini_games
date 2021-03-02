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
    public partial class Game2 : Form
    {
        public Game2(Menu m)
        {
            InitializeComponent();
            menu = m;
            generateButtonsAppearance();
            timer1.Start();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (buttonNumber == button.Name.ToString())
            {
                if (counter >= 5)
                {
                    timer1.Stop();
                    end_label.Text = "TIME:\n" + timerCounter + "ms";
                    end_pictureBox.Visible = end_pictureBox.Enabled = end_label.Visible = exit_button.Enabled = exit_button.Visible = true;
                }
                counter++;
                generateButtonsAppearance();
            }
        }

        private void generateButtonsAppearance()
        {
            Button[] buttons = { this.button1, this.button2, this.button3, this.button4, this.button5,
                                 this.button6, this.button7, this.button8, this.button9};
            Random random = new Random();
            int randomIndex = random.Next(buttons.Length);

            for (int i = 0; i < buttons.Length; i++)
            {
                do
                {
                    randomIndexButtonColor = random.Next(button_colors.Length);
                    randomIndexTextColor = random.Next(text_colors.Length);
                } while ((usedButtonColors.Contains(randomIndexButtonColor) || (usedTextColors.Contains(randomIndexTextColor))));

                while (randomIndexButtonColor == randomIndexTextColor)
                {
                    randomIndexButtonColor = random.Next(button_colors.Length);
                }
                if (randomIndex == i)
                {
                    randomIndexTextColor = randomIndexButtonColor;
                    buttonNumber = buttons[i].Name.ToString();
                }
                usedButtonColors.Add(randomIndexButtonColor);
                usedTextColors.Add(randomIndexTextColor);

                buttons[i].ForeColor = button_colors[randomIndexButtonColor];
                buttons[i].Text = text_colors[randomIndexTextColor];
            }
            usedButtonColors.Clear();
            usedTextColors.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCounter += 50;
            time_counter_label.Text = timerCounter + "ms";
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Visible = menu.Enabled = true;
        }

        private void Game2_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Visible = menu.Enabled = true;
        }
    }
}
