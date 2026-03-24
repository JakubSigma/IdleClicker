using IdleClicker.Properties;
using System;
using System.IO;
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
        private string savePath = "save.json";

        public IdleClicker()
        {
            InitializeComponent();
             SetupMusic();
             this.BackgroundImage = Properties.Resources._1;
             CurrentSave = SaveManager.Load();
             AplikujNastaveni();
        }

        private void SetupMusic()
        {
            if (File.Exists(musicPath))
            {
                musicPlayer.URL = musicPath;
                musicPlayer.settings.setMode("loop", true);

                musicPlayer.controls.play();
            }
        }

        private void AplikujNastaveni()
        {
            // Příklad: Pokud už máš v savu uloženou hlasitost, nastav ji přehrávači
            // musicPlayer.settings.volume = (int)(CurrentSave.MusicVolume * 100);
            musicPlayer.settings.volume = (int)(CurrentSave.MusicVolume);
        }
        public void UpdateVolume(int value)
        {

            musicPlayer.settings.volume = value;

        }

        private void LoadGame()
        {
            if (File.Exists(savePath))
            {
                string json = File.ReadAllText(savePath);
                CurrentSave = JsonSerializer.Deserialize<SaveData>(json);
            }
            else
            {
                CurrentSave = new SaveData();
            }
        }



        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            MainGame mainGame = new MainGame(this);
            mainGame.Show();
            this.Hide();
            mainGame.FormClosed += (s, args) => this.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings(this);
            settingsForm.ShowDialog();

        }
    }
}
