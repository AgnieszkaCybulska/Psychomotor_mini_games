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
    public partial class Game4 : Form
    {
        public Game4(Menu m)
        {
            InitializeComponent();
            menu = m;
            random_location(fruit_picture);
            random_location(yunkFood_picture);
        }

        private void Game4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 'a')
            {
                if (kid.Left > 0)
                {
                    kid.Left -= 10;
                }
            }
            if(e.KeyChar == 'd')
            {
                if (kid.Left < 550)
                {
                    kid.Left += 10;
                }
            }
        }

        private void random_location(PictureBox food)
        {
            Random random = new Random();
            xLocation = random.Next(0, 550);
            if (xLocation >= xPrevious && xLocation <= (xPrevious + food.Width))
            {
                xLocation = random.Next(0, 550);
            }

            if (food == fruit_picture)
            {
                
                fruits_index = random.Next(fruits.Length);
                fruit_picture.BackgroundImage = fruits[fruits_index];
            }
            if (food == yunkFood_picture)
            {
                yunkFood_index = random.Next(yunkFood.Length);
                yunkFood_picture.BackgroundImage = yunkFood[yunkFood_index];
            }
            food.Top = -10;
            food.Left = xLocation;
            xPrevious = xLocation;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fruit_picture.Top += 8;
            yunkFood_picture.Top += 8;
            if (points % 5 == 0)
            {
                fruit_picture.Top += 1;
                yunkFood_picture.Top += 1;
            }
            collision();
        }

        private void collision()
        {
            for (int i = 0; i < (kid.Top + kid.Height); i++)
            {
                for (int j = 0; j < (kid.Left + kid.Width); j++)
                {
                    if ((i > kid.Top && i < (kid.Top + kid.Height)) && (j > kid.Left && j < (kid.Left + kid.Width)))
                    {
                        if (i == (fruit_picture.Top + fruit_picture.Height) && (j == (fruit_picture.Left + fruit_picture.Width)))
                        {
                            points++;
                            label1.Text = "SCORE: " + points.ToString();
                            random_location(fruit_picture);
                        }
                        if (i == (yunkFood_picture.Top + yunkFood_picture.Height) && (j == (yunkFood_picture.Left + yunkFood_picture.Width)))
                        {
                            live--;
                            switch(live)
                            {
                                case 0:
                                    heart1.BackgroundImage = heart2.BackgroundImage = heart3.BackgroundImage = Mini_games.Properties.Resources.empty_heart;
                                    fruit_picture.Visible = fruit_picture.Enabled = yunkFood_picture.Visible = yunkFood_picture.Enabled = false;
                                    end_label.Text = "SCORE:\n" + points;
                                    end_pictureBox.Visible = end_pictureBox.Enabled = end_label.Visible = exit_button.Enabled = exit_button.Visible = true;
                                    break;
                                case 1: 
                                    heart2.BackgroundImage = heart3.BackgroundImage = Mini_games.Properties.Resources.empty_heart;
                                    break;
                                case 2: 
                                    heart3.BackgroundImage = Mini_games.Properties.Resources.empty_heart;
                                    break;
                                case 3:
                                    heart1.BackgroundImage = heart2.BackgroundImage = heart3.BackgroundImage = Mini_games.Properties.Resources.heart;
                                    break;
                            }
                            random_location(yunkFood_picture);
                        }
                    }
                }
            }
            if (fruit_picture.Top >= 350)
            {
                random_location(fruit_picture);
            }
            if (yunkFood_picture.Top >= 350)
            {
                random_location(yunkFood_picture);
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Visible = menu.Enabled = true;
        }

        private void Game4_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Visible = menu.Enabled = true;
        }
    }
}
