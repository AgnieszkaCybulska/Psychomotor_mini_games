
using System.Drawing;
using System.Windows.Forms;

namespace Mini_games
{
    partial class Game3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        Menu menu;
        Button[] buttons = new Button[50];
        Color[] colors = new Color[9] { Color.Red, Color.YellowGreen, Color.MediumOrchid, Color.White, Color.Yellow, Color.DarkOrange, Color.DeepPink, Color.Cyan, Color.Blue };
        int randomIndexColor;
        int randomIndexFace;
        int randomIndexSound;
        bool sound = false;
        int timerCounter = 0;
        int counter = 0;
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
            this.timer_counter_label = new System.Windows.Forms.Label();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.end_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Wheat;
            this.exit_button.Enabled = false;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_button.Location = new System.Drawing.Point(311, 278);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(55, 44);
            this.exit_button.TabIndex = 107;
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
            this.end_label.Location = new System.Drawing.Point(232, 178);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(218, 77);
            this.end_label.TabIndex = 106;
            this.end_label.Text = "TIME:";
            this.end_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.end_label.Visible = false;
            // 
            // end_pictureBox
            // 
            this.end_pictureBox.BackColor = System.Drawing.Color.Ivory;
            this.end_pictureBox.Enabled = false;
            this.end_pictureBox.Location = new System.Drawing.Point(188, 159);
            this.end_pictureBox.Name = "end_pictureBox";
            this.end_pictureBox.Size = new System.Drawing.Size(298, 185);
            this.end_pictureBox.TabIndex = 105;
            this.end_pictureBox.TabStop = false;
            this.end_pictureBox.Visible = false;
            // 
            // timer_counter_label
            // 
            this.timer_counter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timer_counter_label.ForeColor = System.Drawing.Color.White;
            this.timer_counter_label.Location = new System.Drawing.Point(475, 62);
            this.timer_counter_label.Name = "timer_counter_label";
            this.timer_counter_label.Size = new System.Drawing.Size(143, 37);
            this.timer_counter_label.TabIndex = 104;
            this.timer_counter_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button41
            // 
            this.button41.BackColor = System.Drawing.Color.Black;
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button41.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button41.ForeColor = System.Drawing.Color.White;
            this.button41.Location = new System.Drawing.Point(568, 328);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(50, 44);
            this.button41.TabIndex = 103;
            this.button41.Text = "😐";
            this.button41.UseVisualStyleBackColor = false;
            this.button41.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button42
            // 
            this.button42.BackColor = System.Drawing.Color.Black;
            this.button42.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button42.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button42.ForeColor = System.Drawing.Color.White;
            this.button42.Location = new System.Drawing.Point(512, 328);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(50, 44);
            this.button42.TabIndex = 102;
            this.button42.Text = "😐";
            this.button42.UseVisualStyleBackColor = false;
            this.button42.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button43
            // 
            this.button43.BackColor = System.Drawing.Color.Black;
            this.button43.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button43.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button43.ForeColor = System.Drawing.Color.White;
            this.button43.Location = new System.Drawing.Point(456, 328);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(50, 44);
            this.button43.TabIndex = 101;
            this.button43.Text = "😐";
            this.button43.UseVisualStyleBackColor = false;
            this.button43.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button44
            // 
            this.button44.BackColor = System.Drawing.Color.Black;
            this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button44.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button44.ForeColor = System.Drawing.Color.White;
            this.button44.Location = new System.Drawing.Point(400, 328);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(50, 44);
            this.button44.TabIndex = 100;
            this.button44.Text = "😐";
            this.button44.UseVisualStyleBackColor = false;
            this.button44.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button45
            // 
            this.button45.BackColor = System.Drawing.Color.Black;
            this.button45.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button45.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button45.ForeColor = System.Drawing.Color.White;
            this.button45.Location = new System.Drawing.Point(344, 328);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(50, 44);
            this.button45.TabIndex = 99;
            this.button45.Text = "😐";
            this.button45.UseVisualStyleBackColor = false;
            this.button45.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button46
            // 
            this.button46.BackColor = System.Drawing.Color.Black;
            this.button46.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button46.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button46.ForeColor = System.Drawing.Color.White;
            this.button46.Location = new System.Drawing.Point(288, 328);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(50, 44);
            this.button46.TabIndex = 98;
            this.button46.Text = "😐";
            this.button46.UseVisualStyleBackColor = false;
            this.button46.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button47
            // 
            this.button47.BackColor = System.Drawing.Color.Black;
            this.button47.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button47.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button47.ForeColor = System.Drawing.Color.White;
            this.button47.Location = new System.Drawing.Point(232, 328);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(50, 44);
            this.button47.TabIndex = 97;
            this.button47.Text = "😐";
            this.button47.UseVisualStyleBackColor = false;
            this.button47.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button48
            // 
            this.button48.BackColor = System.Drawing.Color.Black;
            this.button48.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button48.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button48.ForeColor = System.Drawing.Color.White;
            this.button48.Location = new System.Drawing.Point(176, 328);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(50, 44);
            this.button48.TabIndex = 96;
            this.button48.Text = "😐";
            this.button48.UseVisualStyleBackColor = false;
            this.button48.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button49
            // 
            this.button49.BackColor = System.Drawing.Color.Black;
            this.button49.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button49.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button49.ForeColor = System.Drawing.Color.White;
            this.button49.Location = new System.Drawing.Point(120, 328);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(50, 44);
            this.button49.TabIndex = 95;
            this.button49.Text = "😐";
            this.button49.UseVisualStyleBackColor = false;
            this.button49.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button50
            // 
            this.button50.BackColor = System.Drawing.Color.Black;
            this.button50.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button50.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button50.ForeColor = System.Drawing.Color.White;
            this.button50.Location = new System.Drawing.Point(64, 328);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(50, 44);
            this.button50.TabIndex = 94;
            this.button50.Text = "😐";
            this.button50.UseVisualStyleBackColor = false;
            this.button50.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.Black;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button31.ForeColor = System.Drawing.Color.White;
            this.button31.Location = new System.Drawing.Point(568, 278);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(50, 44);
            this.button31.TabIndex = 93;
            this.button31.Text = "😐";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.Black;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button32.ForeColor = System.Drawing.Color.White;
            this.button32.Location = new System.Drawing.Point(512, 278);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(50, 44);
            this.button32.TabIndex = 92;
            this.button32.Text = "😐";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.Black;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button33.ForeColor = System.Drawing.Color.White;
            this.button33.Location = new System.Drawing.Point(456, 278);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(50, 44);
            this.button33.TabIndex = 91;
            this.button33.Text = "😐";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.Black;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button34.ForeColor = System.Drawing.Color.White;
            this.button34.Location = new System.Drawing.Point(400, 278);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(50, 44);
            this.button34.TabIndex = 90;
            this.button34.Text = "😐";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.Black;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button35.ForeColor = System.Drawing.Color.White;
            this.button35.Location = new System.Drawing.Point(344, 278);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(50, 44);
            this.button35.TabIndex = 89;
            this.button35.Text = "😐";
            this.button35.UseVisualStyleBackColor = false;
            this.button35.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.Black;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button36.ForeColor = System.Drawing.Color.White;
            this.button36.Location = new System.Drawing.Point(288, 278);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(50, 44);
            this.button36.TabIndex = 88;
            this.button36.Text = "😐";
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.Black;
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button37.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button37.ForeColor = System.Drawing.Color.White;
            this.button37.Location = new System.Drawing.Point(232, 278);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(50, 44);
            this.button37.TabIndex = 87;
            this.button37.Text = "😐";
            this.button37.UseVisualStyleBackColor = false;
            this.button37.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.Black;
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button38.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button38.ForeColor = System.Drawing.Color.White;
            this.button38.Location = new System.Drawing.Point(176, 278);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(50, 44);
            this.button38.TabIndex = 86;
            this.button38.Text = "😐";
            this.button38.UseVisualStyleBackColor = false;
            this.button38.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button39
            // 
            this.button39.BackColor = System.Drawing.Color.Black;
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button39.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button39.ForeColor = System.Drawing.Color.White;
            this.button39.Location = new System.Drawing.Point(120, 278);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(50, 44);
            this.button39.TabIndex = 85;
            this.button39.Text = "😐";
            this.button39.UseVisualStyleBackColor = false;
            this.button39.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.Color.Black;
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button40.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button40.ForeColor = System.Drawing.Color.White;
            this.button40.Location = new System.Drawing.Point(64, 278);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(50, 44);
            this.button40.TabIndex = 84;
            this.button40.Text = "😐";
            this.button40.UseVisualStyleBackColor = false;
            this.button40.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Black;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(568, 228);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(50, 44);
            this.button21.TabIndex = 83;
            this.button21.Text = "😐";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Black;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(512, 228);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(50, 44);
            this.button22.TabIndex = 82;
            this.button22.Text = "😐";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Black;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(456, 228);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(50, 44);
            this.button23.TabIndex = 81;
            this.button23.Text = "😐";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Black;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button24.ForeColor = System.Drawing.Color.White;
            this.button24.Location = new System.Drawing.Point(400, 228);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(50, 44);
            this.button24.TabIndex = 80;
            this.button24.Text = "😐";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Black;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button25.ForeColor = System.Drawing.Color.White;
            this.button25.Location = new System.Drawing.Point(344, 228);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(50, 44);
            this.button25.TabIndex = 79;
            this.button25.Text = "😐";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Black;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button26.ForeColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(288, 228);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(50, 44);
            this.button26.TabIndex = 78;
            this.button26.Text = "😐";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Black;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button27.ForeColor = System.Drawing.Color.White;
            this.button27.Location = new System.Drawing.Point(232, 228);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(50, 44);
            this.button27.TabIndex = 77;
            this.button27.Text = "😐";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Black;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button28.ForeColor = System.Drawing.Color.White;
            this.button28.Location = new System.Drawing.Point(176, 228);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(50, 44);
            this.button28.TabIndex = 76;
            this.button28.Text = "😐";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Black;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button29.ForeColor = System.Drawing.Color.White;
            this.button29.Location = new System.Drawing.Point(120, 228);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(50, 44);
            this.button29.TabIndex = 75;
            this.button29.Text = "😐";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.Black;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button30.ForeColor = System.Drawing.Color.White;
            this.button30.Location = new System.Drawing.Point(64, 228);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(50, 44);
            this.button30.TabIndex = 74;
            this.button30.Text = "😐";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Black;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(568, 178);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(50, 44);
            this.button20.TabIndex = 73;
            this.button20.Text = "😐";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Black;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(512, 178);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(50, 44);
            this.button19.TabIndex = 72;
            this.button19.Text = "😐";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Black;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(456, 178);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(50, 44);
            this.button18.TabIndex = 71;
            this.button18.Text = "😐";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Black;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(400, 178);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(50, 44);
            this.button17.TabIndex = 70;
            this.button17.Text = "😐";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Black;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(344, 178);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(50, 44);
            this.button16.TabIndex = 69;
            this.button16.Text = "😐";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Black;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(288, 178);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 44);
            this.button15.TabIndex = 68;
            this.button15.Text = "😐";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Black;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(232, 178);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(50, 44);
            this.button14.TabIndex = 67;
            this.button14.Text = "😐";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Black;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(176, 178);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 44);
            this.button13.TabIndex = 66;
            this.button13.Text = "😐";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Black;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(120, 178);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 44);
            this.button12.TabIndex = 65;
            this.button12.Text = "😐";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Black;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(64, 178);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 44);
            this.button11.TabIndex = 64;
            this.button11.Text = "😐";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(568, 128);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 44);
            this.button10.TabIndex = 63;
            this.button10.Text = "😐";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(512, 128);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 44);
            this.button9.TabIndex = 62;
            this.button9.Text = "😐";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(456, 128);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 44);
            this.button8.TabIndex = 61;
            this.button8.Text = "😐";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(400, 128);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 44);
            this.button7.TabIndex = 60;
            this.button7.Text = "😐";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(344, 128);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 44);
            this.button6.TabIndex = 59;
            this.button6.Text = "😐";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(288, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 44);
            this.button5.TabIndex = 58;
            this.button5.Text = "😐";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(232, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 44);
            this.button4.TabIndex = 57;
            this.button4.Text = "😐";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(176, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 44);
            this.button3.TabIndex = 56;
            this.button3.Text = "😐";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(120, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 44);
            this.button2.TabIndex = 55;
            this.button2.Text = "😐";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(64, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 44);
            this.button1.TabIndex = 54;
            this.button1.Text = "😐";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttons_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(684, 442);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.end_label);
            this.Controls.Add(this.end_pictureBox);
            this.Controls.Add(this.timer_counter_label);
            this.Controls.Add(this.button41);
            this.Controls.Add(this.button42);
            this.Controls.Add(this.button43);
            this.Controls.Add(this.button44);
            this.Controls.Add(this.button45);
            this.Controls.Add(this.button46);
            this.Controls.Add(this.button47);
            this.Controls.Add(this.button48);
            this.Controls.Add(this.button49);
            this.Controls.Add(this.button50);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Game3";
            this.Text = "Game3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game3_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.end_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label end_label;
        private System.Windows.Forms.PictureBox end_pictureBox;
        private System.Windows.Forms.Label timer_counter_label;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Timer timer1;
    }
}