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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQuoteForm = new ViewAllQuotes();
            viewQuoteForm.Tag = this;
            viewQuoteForm.Show(this);
            Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuoteForm = new SearchQuotes();
            searchQuoteForm.Tag = this;
            searchQuoteForm.Show(this);
            Hide();
        }
    }
}
