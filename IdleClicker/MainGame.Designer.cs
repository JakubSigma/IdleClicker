namespace IdleClicker
{
    partial class MainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            pictureBoxClicker = new PictureBox();
            labelCurrency = new Label();
            button1 = new Button();
            labelUpgrades = new Label();
            labelClickPower = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            labelUpgrade4 = new Label();
            labelUpgrade3 = new Label();
            labelUpgrade2 = new Label();
            labelUpgrade1 = new Label();
            buttonClickPower = new Button();
            labelClickCena = new Label();
            timerCheck = new System.Windows.Forms.Timer(components);
            labelPenizeZaSekundu = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClicker).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClicker
            // 
            pictureBoxClicker.BackColor = Color.Transparent;
            pictureBoxClicker.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxClicker.Location = new Point(397, 144);
            pictureBoxClicker.Name = "pictureBoxClicker";
            pictureBoxClicker.Size = new Size(422, 336);
            pictureBoxClicker.TabIndex = 0;
            pictureBoxClicker.TabStop = false;
            pictureBoxClicker.Click += pictureBoxClicker_Click;
            // 
            // labelCurrency
            // 
            labelCurrency.AutoSize = true;
            labelCurrency.BackColor = Color.Transparent;
            labelCurrency.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelCurrency.Location = new Point(336, 9);
            labelCurrency.Name = "labelCurrency";
            labelCurrency.Size = new Size(170, 45);
            labelCurrency.TabIndex = 1;
            labelCurrency.Text = "Peníze: 0$ ";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(25, 72);
            button1.Name = "button1";
            button1.Size = new Size(282, 89);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelUpgrades
            // 
            labelUpgrades.AutoSize = true;
            labelUpgrades.BackColor = Color.Transparent;
            labelUpgrades.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelUpgrades.Location = new Point(25, 9);
            labelUpgrades.Name = "labelUpgrades";
            labelUpgrades.Size = new Size(156, 45);
            labelUpgrades.TabIndex = 11;
            labelUpgrades.Text = "Vylepšení";
            // 
            // labelClickPower
            // 
            labelClickPower.AutoSize = true;
            labelClickPower.BackColor = Color.Transparent;
            labelClickPower.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelClickPower.Location = new Point(415, 469);
            labelClickPower.Name = "labelClickPower";
            labelClickPower.Size = new Size(191, 45);
            labelClickPower.TabIndex = 12;
            labelClickPower.Text = "Síla kliku: 1";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(25, 197);
            button2.Name = "button2";
            button2.Size = new Size(282, 89);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(25, 322);
            button3.Name = "button3";
            button3.Size = new Size(282, 89);
            button3.TabIndex = 14;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSeaGreen;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(25, 447);
            button4.Name = "button4";
            button4.Size = new Size(282, 89);
            button4.TabIndex = 15;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // labelUpgrade4
            // 
            labelUpgrade4.AutoSize = true;
            labelUpgrade4.BackColor = Color.Transparent;
            labelUpgrade4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelUpgrade4.Location = new Point(25, 539);
            labelUpgrade4.Name = "labelUpgrade4";
            labelUpgrade4.Size = new Size(173, 30);
            labelUpgrade4.TabIndex = 19;
            labelUpgrade4.Text = "Lvl.              Cena";
            // 
            // labelUpgrade3
            // 
            labelUpgrade3.AutoSize = true;
            labelUpgrade3.BackColor = Color.Transparent;
            labelUpgrade3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelUpgrade3.Location = new Point(25, 414);
            labelUpgrade3.Name = "labelUpgrade3";
            labelUpgrade3.Size = new Size(173, 30);
            labelUpgrade3.TabIndex = 20;
            labelUpgrade3.Text = "Lvl.              Cena";
            // 
            // labelUpgrade2
            // 
            labelUpgrade2.AutoSize = true;
            labelUpgrade2.BackColor = Color.Transparent;
            labelUpgrade2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelUpgrade2.Location = new Point(25, 289);
            labelUpgrade2.Name = "labelUpgrade2";
            labelUpgrade2.Size = new Size(173, 30);
            labelUpgrade2.TabIndex = 21;
            labelUpgrade2.Text = "Lvl.              Cena";
            // 
            // labelUpgrade1
            // 
            labelUpgrade1.AutoSize = true;
            labelUpgrade1.BackColor = Color.Transparent;
            labelUpgrade1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelUpgrade1.Location = new Point(25, 164);
            labelUpgrade1.Name = "labelUpgrade1";
            labelUpgrade1.Size = new Size(173, 30);
            labelUpgrade1.TabIndex = 22;
            labelUpgrade1.Text = "Lvl.              Cena";
            // 
            // buttonClickPower
            // 
            buttonClickPower.BackColor = Color.DarkSeaGreen;
            buttonClickPower.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClickPower.FlatStyle = FlatStyle.Flat;
            buttonClickPower.Location = new Point(703, 469);
            buttonClickPower.Name = "buttonClickPower";
            buttonClickPower.Size = new Size(82, 75);
            buttonClickPower.TabIndex = 23;
            buttonClickPower.UseVisualStyleBackColor = false;
            buttonClickPower.Click += buttonClickPower_Click;
            // 
            // labelClickCena
            // 
            labelClickCena.AutoSize = true;
            labelClickCena.BackColor = Color.Transparent;
            labelClickCena.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelClickCena.Location = new Point(415, 514);
            labelClickCena.Name = "labelClickCena";
            labelClickCena.Size = new Size(126, 30);
            labelClickCena.TabIndex = 24;
            labelClickCena.Text = "Cena: $1500";
            // 
            // timerCheck
            // 
            timerCheck.Enabled = true;
            timerCheck.Interval = 1;
            timerCheck.Tick += timerCheck_Tick;
            // 
            // labelPenizeZaSekundu
            // 
            labelPenizeZaSekundu.AutoSize = true;
            labelPenizeZaSekundu.BackColor = Color.Transparent;
            labelPenizeZaSekundu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPenizeZaSekundu.Location = new Point(336, 72);
            labelPenizeZaSekundu.Name = "labelPenizeZaSekundu";
            labelPenizeZaSekundu.Size = new Size(158, 45);
            labelPenizeZaSekundu.TabIndex = 25;
            labelPenizeZaSekundu.Text = "Spin: 1$/s";
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1271, 599);
            Controls.Add(labelPenizeZaSekundu);
            Controls.Add(labelClickCena);
            Controls.Add(buttonClickPower);
            Controls.Add(labelUpgrade1);
            Controls.Add(labelUpgrade2);
            Controls.Add(labelUpgrade3);
            Controls.Add(labelUpgrade4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(labelClickPower);
            Controls.Add(labelUpgrades);
            Controls.Add(button1);
            Controls.Add(labelCurrency);
            Controls.Add(pictureBoxClicker);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Idle Clicker";
            ((System.ComponentModel.ISupportInitialize)pictureBoxClicker).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxClicker;
        private Label labelCurrency;
        private Button button1;
        private Label labelUpgrades;
        private Label labelClickPower;
        private System.Windows.Forms.Timer gameTimer;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label labelPenizeZaSekundu;
        private Label label2;
        private Label label3;
        private Label labelUpgrade4;
        private Label labelUpgrade3;
        private Label labelUpgrade2;
        private Label labelUpgrade1;
        private Button buttonClickPower;
        private Label labelClickCena;
        private System.Windows.Forms.Timer timerCheck;
    }
}