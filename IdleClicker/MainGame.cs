using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleClicker
{
    public partial class MainGame : Form
    {
        private IdleClicker _parent;
        public MainGame(IdleClicker parent)
        {
            InitializeComponent();
            pictureBoxClicker.BackgroundImage = Image.FromFile("click.png");
            this._parent = parent;
            UpdateUI();
        }


        private void UpdateUI()
        {
            // Příklad: Nastavení textu labelu z dat v parentovi
            labelCurrency.Text = "Peníze: " + _parent.CurrentSave.Currency;
        }



        private void pictureBoxClicker_Click(object sender, EventArgs e)
        {

            _parent.CurrentSave.Currency += _parent.CurrentSave.ClickPower;

            labelCurrency.Text = "Peníze: " + _parent.CurrentSave.Currency;

            SaveManager.Save(_parent.CurrentSave);


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
