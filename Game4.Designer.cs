
using System.Drawing;

namespace Mini_games
{
    partial class Game4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Menu menu;
        int xLocation = 0;
        int points = 0;
        int live = 3;
        int xPrevious = 0;

        int fruits_index;
        int yunkFood_index;
        Image[] fruits = { Mini_games.Properties.Resources.apple, Mini_games.Properties.Resources.grape, Mini_games.Properties.Resources.cherry,
                           Mini_games.Properties.Resources.banana, Mini_games.Properties.Resources.strawberry, Mini_games.Properties.Resources.watermelon};

        Image[] yunkFood = { Mini_games.Properties.Resources.pizza, Mini_games.Properties.Resources.burger, Mini_games.Properties.Resources.chocolate,
                           Mini_games.Properties.Resources.fries, Mini_games.Properties.Resources.chips};
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fruit_picture = new System.Windows.Forms.PictureBox();
            this.kid = new System.Windows.Forms.PictureBox();
            this.yunkFood_picture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.end_label = new System.Windows.Forms.Label();
            this.end_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fruit_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yunkFood_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(660, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "SCORE: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fruit_picture
            // 
            this.fruit_picture.BackColor = System.Drawing.Color.Transparent;
            this.fruit_picture.BackgroundImage = global::Mini_games.Properties.Resources.apple;
            this.fruit_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fruit_picture.Location = new System.Drawing.Point(2, 1);
            this.fruit_picture.Name = "fruit_picture";
            this.fruit_picture.Size = new System.Drawing.Size(56, 58);
            this.fruit_picture.TabIndex = 1;
            this.fruit_picture.TabStop = false;
            // 
            // kid
            // 
            this.kid.BackColor = System.Drawing.Color.Transparent;
            this.kid.BackgroundImage = global::Mini_games.Properties.Resources.boy;
            this.kid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kid.Location = new System.Drawing.Point(331, 265);
            this.kid.Name = "kid";
            this.kid.Size = new System.Drawing.Size(107, 176);
            this.kid.TabIndex = 0;
            this.kid.TabStop = false;
            // 
            // yunkFood_picture
            // 
            this.yunkFood_picture.BackColor = System.Drawing.Color.Transparent;
            this.yunkFood_picture.BackgroundImage = global::Mini_games.Properties.Resources.burger;
            this.yunkFood_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yunkFood_picture.Location = new System.Drawing.Point(64, 1);
            this.yunkFood_picture.Name = "yunkFood_picture";
            this.yunkFood_picture.Size = new System.Drawing.Size(56, 58);
            this.yunkFood_picture.TabIndex = 4;
            this.yunkFood_picture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Mini_games.Properties.Resources.background;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 454);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.Transparent;
            this.heart3.BackgroundImage = global::Mini_games.Properties.Resources.heart;
            this.heart3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart3.Location = new System.Drawing.Point(623, 11);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(31, 31);
            this.heart3.TabIndex = 6;
            this.heart3.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.Transparent;
            this.heart2.BackgroundImage = global::Mini_games.Properties.Resources.heart;
            this.heart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart2.Location = new System.Drawing.Point(586, 11);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(31, 31);
            this.heart2.TabIndex = 7;
            this.heart2.TabStop = false;
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Transparent;
            this.heart1.BackgroundImage = global::Mini_games.Properties.Resources.heart;
            this.heart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart1.Location = new System.Drawing.Point(549, 12);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(31, 31);
            this.heart1.TabIndex = 8;
            this.heart1.TabStop = false;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Wheat;
            this.exit_button.Enabled = false;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_button.Location = new System.Drawing.Point(365, 253);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(55, 44);
            this.exit_button.TabIndex = 110;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Visible = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // end_label
            // 
            this.end_label.BackColor = System.Drawing.Color.Ivory;
            this.end_label.Enabled = false;
            this.end_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.end_label.Location = new System.Drawing.Point(286, 153);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(218, 77);
            this.end_label.TabIndex = 109;
            this.end_label.Text = "SCORE:";
            this.end_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.end_label.Visible = false;
            // 
            // end_pictureBox
            // 
            this.end_pictureBox.BackColor = System.Drawing.Color.Ivory;
            this.end_pictureBox.Enabled = false;
            this.end_pictureBox.Location = new System.Drawing.Point(242, 134);
            this.end_pictureBox.Name = "end_pictureBox";
            this.end_pictureBox.Size = new System.Drawing.Size(298, 185);
            this.end_pictureBox.TabIndex = 108;
            this.end_pictureBox.TabStop = false;
            this.end_pictureBox.Visible = false;
            // 
            // Game4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mini_games.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.end_label);
            this.Controls.Add(this.end_pictureBox);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yunkFood_picture);
            this.Controls.Add(this.fruit_picture);
            this.Controls.Add(this.kid);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Game4";
            this.Text = "Game4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game4_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game4_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.fruit_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yunkFood_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kid;
        private System.Windows.Forms.PictureBox fruit_picture;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox yunkFood_picture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label end_label;
        private System.Windows.Forms.PictureBox end_pictureBox;
    }
}