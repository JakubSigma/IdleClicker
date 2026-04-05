using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace IdleClicker
{
    public partial class MainGame : Form
    {
        private IdleClicker _parent;
        private PrivateFontCollection pfc = new PrivateFontCollection();
        private int[] MultiplierUpgrade = { 5, 50, 500, 5000 };

        public MainGame(IdleClicker parent)
        {
            InitializeComponent();
            fontLoad();
            FontApply();
            pictureBoxClicker.BackgroundImage = Properties.Resources.click;
            button1.BackgroundImage = Properties.Resources.tusk;
            button2.BackgroundImage = Properties.Resources.d4c;
            button3.BackgroundImage = Properties.Resources.world;
            button4.BackgroundImage = Properties.Resources.rainbow;
            buttonClickPower.BackgroundImage = Properties.Resources.jojo;
            this.BackgroundImage = Properties.Resources.bg;
            this._parent = parent;
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 3;
            }
            UpdateUI();
        }

        // Metoda pro aktualizaci všech labelů
        private void UpdateUI()
        {
            labelCurrency.Text = "Peníze: $" + _parent.CurrentSave.Currency;
            labelClickPower.Text = "Síla kliknutí: " + _parent.CurrentSave.ClickPower;
            labelUpgrade1.Text = $"Lvl. {_parent.CurrentSave.UpgradeLevels[0]}             Cena: ${_parent.CurrentSave.UpgradePrice[0]}";
            labelUpgrade2.Text = $"Lvl. {_parent.CurrentSave.UpgradeLevels[1]}             Cena: ${_parent.CurrentSave.UpgradePrice[1]}";
            labelUpgrade3.Text = $"Lvl. {_parent.CurrentSave.UpgradeLevels[2]}             Cena: ${_parent.CurrentSave.UpgradePrice[2]}";
            labelUpgrade4.Text = $"Lvl. {_parent.CurrentSave.UpgradeLevels[3]}             Cena: ${_parent.CurrentSave.UpgradePrice[3]}";
            labelClickPower.Text = "Síla kliknutí: " + _parent.CurrentSave.ClickPower;
            labelClickCena.Text = $"Cena: ${1500 * _parent.CurrentSave.ClickPower}";
        }

        //Generace penez podle IdleGenu a ClickPoweru
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            _parent.CurrentSave.Currency += _parent.CurrentSave.ClickPower * _parent.CurrentSave.IdleGen;
            labelPenizeZaSekundu.Text = $"Spin: ${_parent.CurrentSave.ClickPower * _parent.CurrentSave.IdleGen}/s";
        }

        // Kliknutí na obrázek
        private void pictureBoxClicker_Click(object sender, EventArgs e)
        {
            _parent.CurrentSave.Currency += _parent.CurrentSave.ClickPower;
            SaveManager.Save(_parent.CurrentSave);
        }

        // Nacitani fontu z resources a přidání do PrivateFontCollection
        public void fontLoad()
        {
            byte[] fontData = Properties.Resources.Fedora;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            pfc.AddMemoryFont(fontPtr, fontData.Length);
            Marshal.FreeCoTaskMem(fontPtr);
        }

        // Font aplikace 
        private void FontApply()
        {
            labelCurrency.Font = new Font(pfc.Families[0], 24);
            labelClickPower.Font = new Font(pfc.Families[0], 24);
            labelUpgrades.Font = new Font(pfc.Families[0], 24);
            labelPenizeZaSekundu.Font = new Font(pfc.Families[0], 24);
            labelUpgrade1.Font = new Font(pfc.Families[0], 14);
            labelUpgrade2.Font = new Font(pfc.Families[0], 14);
            labelUpgrade3.Font = new Font(pfc.Families[0], 14);
            labelUpgrade4.Font = new Font(pfc.Families[0], 14);
            labelClickCena.Font = new Font(pfc.Families[0], 14);
        }

        // Upgrade tlacitka, save progresu automaticky pri kliknuti, zvyseni ceny a levelu, zvyseni IdleGenu o dany multiplier, check jestli ma hrac dost penez, pokud ne, tlacitko se nezaktivuje
        private void button1_Click(object sender, EventArgs e)
        {
            if (_parent.CurrentSave.Currency - _parent.CurrentSave.UpgradePrice[0] >= 0)
            {
                _parent.CurrentSave.Currency -= _parent.CurrentSave.UpgradePrice[0];
                _parent.CurrentSave.IdleGen += MultiplierUpgrade[0];
                _parent.CurrentSave.UpgradeLevels[0]++;
                _parent.CurrentSave.UpgradePrice[0] = _parent.CurrentSave.UpgradePrice[0] * 2;
                button1.Enabled = false;
                SaveManager.Save(_parent.CurrentSave);
            }

        }

        // Upgrade tlacitka, save progresu automaticky pri kliknuti, zvyseni ceny a levelu, zvyseni IdleGenu o dany multiplier, check jestli ma hrac dost penez, pokud ne, tlacitko se nezaktivuje
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (_parent.CurrentSave.Currency - _parent.CurrentSave.UpgradePrice[1] >= 0)
            {
                _parent.CurrentSave.Currency -= _parent.CurrentSave.UpgradePrice[1];
                _parent.CurrentSave.IdleGen += MultiplierUpgrade[1];
                _parent.CurrentSave.UpgradeLevels[1]++;
                _parent.CurrentSave.UpgradePrice[1] = _parent.CurrentSave.UpgradePrice[1] * 3;
                button2.Enabled = false;
                SaveManager.Save(_parent.CurrentSave);
            }

        }

        // Upgrade tlacitka, save progresu automaticky pri kliknuti, zvyseni ceny a levelu, zvyseni IdleGenu o dany multiplier, check jestli ma hrac dost penez, pokud ne, tlacitko se nezaktivuje

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (_parent.CurrentSave.Currency - _parent.CurrentSave.UpgradePrice[2] >= 0)
            {
                _parent.CurrentSave.Currency -= _parent.CurrentSave.UpgradePrice[2];
                _parent.CurrentSave.IdleGen += MultiplierUpgrade[2];
                _parent.CurrentSave.UpgradeLevels[2]++;
                _parent.CurrentSave.UpgradePrice[2] = _parent.CurrentSave.UpgradePrice[2] * 4;
                button3.Enabled = false;
                SaveManager.Save(_parent.CurrentSave);
            }


        }

        // Upgrade tlacitka, save progresu automaticky pri kliknuti, zvyseni ceny a levelu, zvyseni IdleGenu o dany multiplier, check jestli ma hrac dost penez, pokud ne, tlacitko se nezaktivuje
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (_parent.CurrentSave.Currency - _parent.CurrentSave.UpgradePrice[3] >= 0)
            {
                _parent.CurrentSave.Currency -= _parent.CurrentSave.UpgradePrice[3];
                _parent.CurrentSave.IdleGen += MultiplierUpgrade[3];
                _parent.CurrentSave.UpgradeLevels[3]++;
                _parent.CurrentSave.UpgradePrice[3] = _parent.CurrentSave.UpgradePrice[3] * 5;
                button4.Enabled = false;
                SaveManager.Save(_parent.CurrentSave);
            }
            
        }

        // Sila kliknuti, save, zvednuti ceny
        private void buttonClickPower_Click(object sender, EventArgs e)
        {
            int cena = 1500;
            _parent.CurrentSave.ClickPower++;
            _parent.CurrentSave.Currency -= cena * _parent.CurrentSave.ClickPower;
            SaveManager.Save(_parent.CurrentSave);

        }

        // Timer pro kontrolu, jestli má hráč dost peněz na upgrade, pokud ano, tlacitko se aktivuje, pokud ne, tlacitko se deaktivuje
        private void timerCheck_Tick(object sender, EventArgs e)
        {
            UpdateUI();
            if (_parent.CurrentSave.Currency >= _parent.CurrentSave.UpgradePrice[0])
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            if (_parent.CurrentSave.Currency >= _parent.CurrentSave.UpgradePrice[1])
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }

            if (_parent.CurrentSave.Currency >= _parent.CurrentSave.UpgradePrice[2])
            {
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }
            if (_parent.CurrentSave.Currency >= _parent.CurrentSave.UpgradePrice[3])
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
            if (_parent.CurrentSave.ClickPower >= 25 || _parent.CurrentSave.Currency < 1500 * _parent.CurrentSave.ClickPower)
            {
                buttonClickPower.Enabled = false;
            }
            else
            {
                buttonClickPower.Enabled = true;
            }
            if (_parent.CurrentSave.Currency < 0)
            {
                _parent.CurrentSave.Currency = 0;
            }
        }
    }
}
