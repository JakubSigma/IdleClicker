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

            musicPlayer.settings.volume = CurrentSave.MusicVolume;
        }
        public void UpdateVolume(int value)
        {

            CurrentSave.MusicVolume = value;
            SaveManager.Save(CurrentSave);
            AplikujNastaveni();

        }



        public void fontLoad()
        {
            byte[] fontData = Properties.Resources.Fedora;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            pfc.AddMemoryFont(fontPtr, fontData.Length);
            Marshal.FreeCoTaskMem(fontPtr);
        }

        private void FontApply()
        {

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
