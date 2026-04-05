// Jakub Šíma, 4.C, PVA Idle Clicker
using IdleClicker.Properties;
using System;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Windows.Forms;
using WMPLib;
namespace IdleClicker
{
    public partial class IdleClicker : Form
    {

        private WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();
        private string musicPath = "sbr.mp3";
        public SaveData CurrentSave;
        private PrivateFontCollection pfc = new PrivateFontCollection();
        public IdleClicker()
        {
            InitializeComponent();
             SetupMusic();
             this.BackgroundImage = Properties.Resources._1;
            pictureBoxName.BackgroundImage = Properties.Resources.name;
            CurrentSave = SaveManager.Load();
             AplikujNastaveni();
            fontLoad();
            FontApply();
        }

        // Metoda pro nastavení hudby
        private void SetupMusic()
        {
            if (File.Exists(musicPath))
            {
                musicPlayer.URL = musicPath;
                musicPlayer.settings.setMode("loop", true);
                musicPlayer.controls.play();
            }
        }

        // Aplikace hlasitosti
        private void AplikujNastaveni()
        {
            musicPlayer.settings.volume = CurrentSave.MusicVolume;
        }

        //Aktualizace hlasitosti a uložení do souboru
        public void UpdateVolume(int value)
        {
            CurrentSave.MusicVolume = value;
            SaveManager.Save(CurrentSave);
            AplikujNastaveni();

        }


        // Font load z resources
        public void fontLoad()
        {
            byte[] fontData = Properties.Resources.Fedora;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            pfc.AddMemoryFont(fontPtr, fontData.Length);
            Marshal.FreeCoTaskMem(fontPtr);
        }

        // Aplikace fontu 
        private void FontApply()
        {
            buttonNewGame.Font = new Font(pfc.Families[0], 24);
            buttonSettings.Font = new Font(pfc.Families[0], 24);
            buttonQuit.Font = new Font(pfc.Families[0], 24);
        }

        // Vypnuti hry
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Button hra, otevření hlavní hry a skrytí menu a znovu zobrazení menu po zavření hlavní hry
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            MainGame mainGame = new MainGame(this);
            mainGame.Show();
            this.Hide();
            mainGame.FormClosed += (s, args) => this.Show();
        }

        // Settings 
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings(this);
            settingsForm.ShowDialog();

        }
    }
}
