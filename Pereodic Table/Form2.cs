using System;
using System.Windows.Forms;

namespace Pereodic_Table
{
    public partial class Form2 : Form
    {

        public Form2(string text, string title, string fileName)
        {
            InitializeComponent();
            this.Text = "Информация об элементе: " + title;
            webBrowser1.Navigate(fileName);
        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
