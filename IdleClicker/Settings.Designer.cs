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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            trackBarHudba = new TrackBar();
            labelMusic = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarHudba).BeginInit();
            SuspendLayout();
            // 
            // trackBarHudba
            // 
            trackBarHudba.Location = new Point(291, 115);
            trackBarHudba.Maximum = 100;
            trackBarHudba.Name = "trackBarHudba";
            trackBarHudba.Size = new Size(208, 45);
            trackBarHudba.TabIndex = 2;
            trackBarHudba.TickStyle = TickStyle.None;
            trackBarHudba.Value = 50;
            trackBarHudba.Scroll += trackBarHudba_Scroll;
            // 
            // labelMusic
            // 
            labelMusic.AutoSize = true;
            labelMusic.Font = new Font("Segoe UI", 24F);
            labelMusic.Location = new Point(291, 67);
            labelMusic.Name = "labelMusic";
            labelMusic.Size = new Size(254, 45);
            labelMusic.TabIndex = 7;
            labelMusic.Text = "Hlasitost Hudby:";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMusic);
            Controls.Add(trackBarHudba);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Settings";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)trackBarHudba).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar trackBarHudba;
        private Label labelMusic;
    }
}