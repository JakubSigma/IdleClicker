namespace IdleClicker
{
    partial class IdleClicker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            buttonNewGame = new Button();
            buttonSettings = new Button();
            buttonQuit = new Button();
            pictureBoxName = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxName).BeginInit();
            SuspendLayout();
            // 
            // buttonNewGame
            // 
            buttonNewGame.BackColor = Color.PeachPuff;
            buttonNewGame.FlatStyle = FlatStyle.Flat;
            buttonNewGame.Location = new Point(476, 193);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(311, 66);
            buttonNewGame.TabIndex = 1;
            buttonNewGame.Text = "Hrát";
            buttonNewGame.UseVisualStyleBackColor = false;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.PeachPuff;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Location = new Point(476, 306);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(311, 66);
            buttonSettings.TabIndex = 2;
            buttonSettings.Text = "Nastavení";
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonQuit
            // 
            buttonQuit.BackColor = Color.PeachPuff;
            buttonQuit.FlatStyle = FlatStyle.Flat;
            buttonQuit.Location = new Point(476, 420);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(311, 66);
            buttonQuit.TabIndex = 3;
            buttonQuit.Text = "Ukončit hru";
            buttonQuit.UseVisualStyleBackColor = false;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // pictureBoxName
            // 
            pictureBoxName.BackColor = Color.Transparent;
            pictureBoxName.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxName.Location = new Point(399, 39);
            pictureBoxName.Name = "pictureBoxName";
            pictureBoxName.Size = new Size(467, 114);
            pictureBoxName.TabIndex = 5;
            pictureBoxName.TabStop = false;
            // 
            // IdleClicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1232, 599);
            Controls.Add(pictureBoxName);
            Controls.Add(buttonQuit);
            Controls.Add(buttonSettings);
            Controls.Add(buttonNewGame);
            Name = "IdleClicker";
            Text = "Idle Clicker";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxName).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private Button buttonNewGame;
        private Button buttonSettings;
        private Button buttonQuit;
        private PictureBox pictureBoxName;
    }
}
