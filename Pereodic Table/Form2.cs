using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pereodic_Table
{
    public partial class Form2 : Form
    {
        string videoFileName;

        public Form2(string text, string title, string fileName, string videoName)
        {
            InitializeComponent();
            videoFileName = videoName;
            Text = "Информация об элементе: " + title;
            webBrowser1.Navigate(fileName);

        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void showVideoBtn_Click(object sender, EventArgs e)
        {
            Process.Start(videoFileName);
        }

        private void closeInfoBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
