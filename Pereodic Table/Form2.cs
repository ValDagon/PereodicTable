using System;
using System.Windows.Forms;

namespace Pereodic_Table
{
    public partial class Form2 : Form
    {

        public Form2(string text, string title)
        {
            InitializeComponent();
            this.Text = "Информация об элементе: " + title;
            infoLabel.Text = text;
        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
