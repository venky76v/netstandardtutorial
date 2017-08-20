using System;
using System.Windows.Forms;
using netstandardclasslibrary;

namespace TestNetStandardLibraryWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestChecker_Click(object sender, EventArgs e)
        {
            if (txtChecker.Text.StartsWithUpper())
                MessageBox.Show($"{"The text you enterted : "}{txtChecker.Text}{" starts with a upper case letter"}");

            if (txtChecker.Text.StartsWithLower())
                MessageBox.Show($"{"The text you enterted : "}{txtChecker.Text}{" starts with a lower case letter"}");

            if (txtChecker.Text.StartsWithNumber())
                MessageBox.Show($"{"The text you enterted : "}{txtChecker.Text}{" starts with a number"}");
        }
    }
}
