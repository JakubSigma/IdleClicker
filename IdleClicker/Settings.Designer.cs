namespace IdleClicker
{
    partial class Settings
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
            trackBarHudba = new TrackBar();
            trackBarSFX = new TrackBar();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            labelMusic = new Label();
            labelSFX = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarHudba).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSFX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // trackBarHudba
            // 
            trackBarHudba.Location = new Point(278, 279);
            trackBarHudba.Maximum = 100;
            trackBarHudba.Name = "trackBarHudba";
            trackBarHudba.Size = new Size(208, 45);
            trackBarHudba.TabIndex = 2;
            trackBarHudba.TickStyle = TickStyle.None;
            trackBarHudba.Value = 50;
            trackBarHudba.Scroll += trackBarHudba_Scroll;
            // 
            // trackBarSFX
            // 
            trackBarSFX.Location = new Point(278, 183);
            trackBarSFX.Maximum = 100;
            trackBarSFX.Name = "trackBarSFX";
            trackBarSFX.Size = new Size(208, 45);
            trackBarSFX.TabIndex = 3;
            trackBarSFX.TickStyle = TickStyle.None;
            trackBarSFX.Value = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(278, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 58);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(372, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 58);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(474, 62);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 58);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // labelMusic
            // 
            labelMusic.AutoSize = true;
            labelMusic.Font = new Font("Segoe UI", 24F);
            labelMusic.Location = new Point(278, 231);
            labelMusic.Name = "labelMusic";
            labelMusic.Size = new Size(254, 45);
            labelMusic.TabIndex = 7;
            labelMusic.Text = "Hlasitost Hudby:";
            // 
            // labelSFX
            // 
            labelSFX.AutoSize = true;
            labelSFX.Font = new Font("Segoe UI", 24F);
            labelSFX.Location = new Point(278, 135);
            labelSFX.Name = "labelSFX";
            labelSFX.Size = new Size(221, 45);
            labelSFX.TabIndex = 8;
            labelSFX.Text = "Hlasitost SFX: ";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSFX);
            Controls.Add(labelMusic);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(trackBarSFX);
            Controls.Add(trackBarHudba);
            Name = "Settings";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)trackBarHudba).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSFX).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar trackBarHudba;
        private TrackBar trackBarSFX;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label labelMusic;
        private Label labelSFX;
    }
}