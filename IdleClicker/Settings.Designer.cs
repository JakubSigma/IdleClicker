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
            buttonUlozit = new Button();
            trackBarHudba = new TrackBar();
            trackBarSFX = new TrackBar();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarHudba).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSFX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // buttonUlozit
            // 
            buttonUlozit.FlatStyle = FlatStyle.Flat;
            buttonUlozit.Location = new Point(267, 337);
            buttonUlozit.Name = "buttonUlozit";
            buttonUlozit.Size = new Size(311, 66);
            buttonUlozit.TabIndex = 1;
            buttonUlozit.Text = "Uložit nastavení";
            buttonUlozit.UseVisualStyleBackColor = true;
            // 
            // trackBarHudba
            // 
            trackBarHudba.Location = new Point(404, 247);
            trackBarHudba.Maximum = 100;
            trackBarHudba.Name = "trackBarHudba";
            trackBarHudba.Size = new Size(104, 45);
            trackBarHudba.TabIndex = 2;
            trackBarHudba.TickStyle = TickStyle.None;
            trackBarHudba.Value = 50;
            trackBarHudba.Scroll += trackBarHudba_Scroll;
            // 
            // trackBarSFX
            // 
            trackBarSFX.Location = new Point(404, 180);
            trackBarSFX.Maximum = 100;
            trackBarSFX.Name = "trackBarSFX";
            trackBarSFX.Size = new Size(104, 45);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 247);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 7;
            label1.Text = "Hlasitost Hudby";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 180);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 8;
            label2.Text = "Hlasitost SFX";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(trackBarSFX);
            Controls.Add(trackBarHudba);
            Controls.Add(buttonUlozit);
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

        private Button buttonUlozit;
        private TrackBar trackBarHudba;
        private TrackBar trackBarSFX;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
    }
}