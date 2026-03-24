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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // buttonNewGame
            // 
            buttonNewGame.BackColor = Color.PeachPuff;
            buttonNewGame.FlatStyle = FlatStyle.Flat;
            buttonNewGame.Location = new Point(478, 155);
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
            buttonSettings.Location = new Point(478, 268);
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
            buttonQuit.Location = new Point(478, 382);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(311, 66);
            buttonQuit.TabIndex = 3;
            buttonQuit.Text = "Ukončit hru";
            buttonQuit.UseVisualStyleBackColor = false;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(493, 35);
            label1.Name = "label1";
            label1.Size = new Size(287, 59);
            label1.TabIndex = 4;
            label1.Text = "IDLE CLICKER";
            // 
            // IdleClicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1232, 599);
            Controls.Add(label1);
            Controls.Add(buttonQuit);
            Controls.Add(buttonSettings);
            Controls.Add(buttonNewGame);
            Name = "IdleClicker";
            Text = "Idle Clicker";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Button buttonNewGame;
        private Button buttonSettings;
        private Button buttonQuit;
        private Label label1;
    }
}
