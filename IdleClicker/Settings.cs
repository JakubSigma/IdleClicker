namespace IdleClicker
{
    public partial class Settings : Form
    {

        private IdleClicker _parent;

        public Settings(IdleClicker parent)
        {
            InitializeComponent();
  
            this._parent = parent;
            updateUI();


        }

        // Nastaveni hlasitosti
        private void updateUI()
        {
            trackBarHudba.Value = _parent.CurrentSave.MusicVolume;
          
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            
        }

        // Aktualizace hlasitosti při posouvání trackbaru
        private void trackBarHudba_Scroll(object sender, EventArgs e)
        {
            
            _parent.UpdateVolume(trackBarHudba.Value);
        }
    }
}