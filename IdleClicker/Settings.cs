namespace IdleClicker
{
    public partial class Settings : Form
    {

        private IdleClicker _parent;

        public Settings(IdleClicker parent) // Tady taky změna
        {
            InitializeComponent();
            this._parent = parent;

            // Nastavení trackbaru podle načteného savu
            if (_parent.CurrentSave != null)
            {
                trackBarHudba.Value = (int)(_parent.CurrentSave.MusicVolume);
            }
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            SaveManager.Save(_parent.CurrentSave);
            MessageBox.Show("Uloženo!");
        }

        private void trackBarHudba_Scroll(object sender, EventArgs e)
        {
            // Voláme metodu v hlavním okně
            _parent.UpdateVolume(trackBarHudba.Value);
        }
    }
}