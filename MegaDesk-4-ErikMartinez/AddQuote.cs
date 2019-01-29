using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_ErikMartinez
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void addNewQoute_Button_Click(object sender, EventArgs e)
        {
            var desk = new Desk();
            desk.Width = Int32.Parse(width.Text);
            desk.Depth = Int32.Parse(depth.Text);
            desk.Drawers = Int32.Parse(drawers.Text);
            
        }
    }
}
