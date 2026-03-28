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
            this.BackgroundImage = Properties.Resources.bg;
            this._parent = parent;
            UpdateUI();

        }

        private void UpdateUI()
        {
            // Příklad: Nastavení textu labelu z dat v parentovi
            labelCurrency.Text = "Peníze: " + _parent.CurrentSave.Currency;

            labelClickPower.Text = "Síla kliknutí: " + _parent.CurrentSave.ClickPower;

            labelUpgrade1.Text = $"Lvl. {_parent.CurrentSave.UpgradeLevels[0]}             Cena: {_parent.CurrentSave.UpgradePrice[0]}";
            labelUpgrade2.Text = $"Lvl. {_parent.CurrentSave.UpgradeLevels[1]}             Cena: {_parent.CurrentSave.UpgradePrice[1]}";
            labelUpgrade3.Text = $"Lvl. {_parent.CurrentSave.UpgradeLevels[2]}             Cena: {_parent.CurrentSave.UpgradePrice[2]}";
            labelUpgrade4.Text = $"Lvl. {_parent.CurrentSave.UpgradeLevels[3]}             Cena: {_parent.CurrentSave.UpgradePrice[3]}";
            labelClickPower.Text = "Síla kliknutí: " + _parent.CurrentSave.ClickPower;

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            _parent.CurrentSave.Currency += _parent.CurrentSave.ClickPower * _parent.CurrentSave.IdleGen;
            UpdateUI();
        }
        private void pictureBoxClicker_Click(object sender, EventArgs e)
        {

            _parent.CurrentSave.Currency += _parent.CurrentSave.ClickPower;

            labelCurrency.Text = "Peníze: " + _parent.CurrentSave.Currency;

            SaveManager.Save(_parent.CurrentSave);
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
            labelCurrency.Font = new Font(pfc.Families[0], 24);
            labelClickPower.Font = new Font(pfc.Families[0], 24);
            labelUpgrades.Font = new Font(pfc.Families[0], 24);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _parent.CurrentSave.Currency -= _parent.CurrentSave.UpgradePrice[1];
            UpdateUI();
            _parent.CurrentSave.IdleGen += MultiplierUpgrade[0];
            _parent.CurrentSave.UpgradeLevels[0]++;
            _parent.CurrentSave.UpgradePrice[0] = _parent.CurrentSave.UpgradePrice[0] * 2;
            button1.Enabled = false;
            SaveManager.Save(_parent.CurrentSave);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            _parent.CurrentSave.Currency -= _parent.CurrentSave.UpgradePrice[1];
            UpdateUI();
            _parent.CurrentSave.IdleGen += MultiplierUpgrade[1];
            _parent.CurrentSave.UpgradeLevels[1]++;
            _parent.CurrentSave.UpgradePrice[1] = _parent.CurrentSave.UpgradePrice[1] * 3;
            button2.Enabled = false;
            SaveManager.Save(_parent.CurrentSave);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            _parent.CurrentSave.Currency -= _parent.CurrentSave.UpgradePrice[2];
            UpdateUI();
            _parent.CurrentSave.IdleGen += MultiplierUpgrade[2];
            _parent.CurrentSave.UpgradeLevels[2]++;
            _parent.CurrentSave.UpgradePrice[2] = _parent.CurrentSave.UpgradePrice[2] * 4;
            button3.Enabled = false;
            SaveManager.Save(_parent.CurrentSave);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            _parent.CurrentSave.Currency -= _parent.CurrentSave.UpgradePrice[3];
            UpdateUI();
            _parent.CurrentSave.IdleGen += MultiplierUpgrade[3];
            _parent.CurrentSave.UpgradeLevels[3]++;
            _parent.CurrentSave.UpgradePrice[3] = _parent.CurrentSave.UpgradePrice[3] * 5;
            button4.Enabled = false;
            SaveManager.Save(_parent.CurrentSave);
        }

        private void buttonClickPower_Click(object sender, EventArgs e)
        {
            int cena = 50;
            _parent.CurrentSave.ClickPower++;
            _parent.CurrentSave.Currency -= cena * _parent.CurrentSave.ClickPower;
            UpdateUI();
            labelClickCena.Text = $"Cena: {50 * _parent.CurrentSave.ClickPower}";
            SaveManager.Save(_parent.CurrentSave);

        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
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
            if (_parent.CurrentSave.ClickPower >= 25)
            {
                buttonClickPower.Enabled = false;
            }
        }
    }
}
