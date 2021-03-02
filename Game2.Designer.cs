
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mini_games
{
    partial class Game2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        Menu menu;
        Button[] buttons = new Button[9];
        Color[] button_colors = new Color[9] { Color.Red, Color.YellowGreen, Color.MediumOrchid, Color.White, Color.Yellow, Color.DarkOrange, Color.DeepPink, Color.Cyan, Color.Blue };
        string[] text_colors = new string[9] { "RED", "GREEN", "PURPLE", "WHITE", "YELLOW", "ORANGE", "PINK", "CYAN", "BLUE" };
        int randomIndexTextColor;
        int randomIndexButtonColor;
        string buttonNumber;
        int timerCounter = 0;
        int counter = 0;
        List<int> usedButtonColors = new List<int>();
        List<int> usedTextColors = new List<int>();
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
            this.exit_button = new System.Windows.Forms.Button();
            this.end_label = new System.Windows.Forms.Label();
            this.end_pictureBox = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.time_counter_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.end_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Wheat;
            this.exit_button.Enabled = false;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Location = new System.Drawing.Point(267, 228);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(55, 44);
            this.exit_button.TabIndex = 24;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Visible = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // end_label
            // 
            this.end_label.BackColor = System.Drawing.Color.Ivory;
            this.end_label.Enabled = false;
            this.end_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.end_label.Location = new System.Drawing.Point(180, 133);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(226, 92);
            this.end_label.TabIndex = 23;
            this.end_label.Text = "TIME:";
            this.end_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.end_label.Visible = false;
            // 
            // end_pictureBox
            // 
            this.end_pictureBox.BackColor = System.Drawing.Color.Ivory;
            this.end_pictureBox.Enabled = false;
            this.end_pictureBox.Location = new System.Drawing.Point(136, 115);
            this.end_pictureBox.Name = "end_pictureBox";
            this.end_pictureBox.Size = new System.Drawing.Size(313, 180);
            this.end_pictureBox.TabIndex = 22;
            this.end_pictureBox.TabStop = false;
            this.end_pictureBox.Visible = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(73, 251);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 82);
            this.button7.TabIndex = 21;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(220, 251);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(141, 82);
            this.button8.TabIndex = 20;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button9.Location = new System.Drawing.Point(367, 251);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(141, 82);
            this.button9.TabIndex = 19;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(220, 163);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 82);
            this.button5.TabIndex = 18;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(367, 163);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 82);
            this.button6.TabIndex = 17;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(367, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 82);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(73, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 82);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(220, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 82);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(73, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 82);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttons_Click);
            // 
            // time_counter_label
            // 
            this.time_counter_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.time_counter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time_counter_label.ForeColor = System.Drawing.Color.White;
            this.time_counter_label.Location = new System.Drawing.Point(367, 21);
            this.time_counter_label.Name = "time_counter_label";
            this.time_counter_label.Size = new System.Drawing.Size(141, 51);
            this.time_counter_label.TabIndex = 25;
            this.time_counter_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(608, 401);
            this.Controls.Add(this.time_counter_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.end_label);
            this.Controls.Add(this.end_pictureBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Game2";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.end_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label end_label;
        private System.Windows.Forms.PictureBox end_pictureBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label time_counter_label;
        private System.Windows.Forms.Timer timer1;
    }
}