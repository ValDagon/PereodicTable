using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Pereodic_Table
{
    public partial class Form2 : Form
    {
        string videoFileName;
        string btnName;

        public Form2(string text, string title, string fileName, string videoName)
        {
            InitializeComponent();
            MaximizeBox = false;

            videoFileName = videoName;
            btnName = title;

            Text = "Информация об элементе: " + title;
            webBrowser1.Navigate(fileName);

            if (btnName == "I")
            {
                showVideoBtn.Text = "Получение йода";
                moreVideoBtn1.Text = "Возгонка йода";
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "Fe")
            {
                moreVideoBtn1.Text = "Гидроксид железа II";
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "Co")
            {
                showVideoBtn.Text = "Гидроксид кобальта II";
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "Mn")
            {
                showVideoBtn.Text = "Гидроксид марганца";
                moreVideoBtn1.Text = "Окислительные свойства диоксида марганца";
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "Ni")
            {
                showVideoBtn.Text = "Гидроксид никеля";
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "P")
            {
                showVideoBtn.Text = "Горение фосфора";
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "Cu")
            {
                moreVideoBtn1.Text = "Обнаружение меди";
                moreVideoBtn2.Text = "Сульфат меди";
            }
            else if (btnName == "Br")
            {
                showVideoBtn.Text = "Получение брома";
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "Cl")
            {
                showVideoBtn.Text = "Получение хлора";
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "Ag")
            {
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "Ba")
            {
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "Ca")
            {
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "Cd")
            {
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "K")
            {
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "Li")
            {
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "Mg")
            {
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "Na")
            {
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "Sr")
            {
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
            }
            else if (btnName == "Zn")
            {
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
            }
            else
            {
                Controls.Remove(showVideoBtn);
                Controls.Remove(moreVideoBtn1);
                Controls.Remove(moreVideoBtn2);
                closeInfoBtn.Width = 785;
                this.Height = 635;
            }
        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void showVideoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnName == "Ag")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Ag.wmv");
                }
                if (btnName == "Ba")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Ba.wmv");
                }
                if (btnName == "Ca")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Ca.wmv");
                }
                if (btnName == "Cd")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Cd.avi");
                }
                if (btnName == "K")
                {
                    Process.Start(Application.StartupPath + @"\files\video\K.wmv");
                }
                if (btnName == "Li")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Li.wmv");
                }
                if (btnName == "Mg")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Mg.wmv");
                }
                if (btnName == "Na")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Na.wmv");
                }
                if (btnName == "Sr")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Sr.wmv");
                }
                if (btnName == "Zn")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Zn.wmv");
                }
                if (btnName == "I")
                {
                    Process.Start(Application.StartupPath + @"\files\video\получение йода.wmv");
                }
                if (btnName == "Fe")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Fe.wmv");
                }
                if (btnName == "Co")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Гидроксид кобальта.wmv");
                }
                if (btnName == "Mn")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Гидроксид марганца 2.wmv");
                }
                if (btnName == "Ni")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Гидроксид никеля.wmv");
                }
                if (btnName == "P")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Горение фосфора.wmv");
                }
                if (btnName == "Cu")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Cu.wmv");
                }
                if (btnName == "Br")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Получение брома.wmv");
                }
                if (btnName == "Cl")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Получение хлора.wmv");
                }
            }
            catch
            {
                MessageBox.Show(
                "Что-то пошло не так",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void moreVideoBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnName == "I")
                {
                    Process.Start(Application.StartupPath + @"\files\video\возгонка йода.wmv");
                }

                if (btnName == "Fe")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Гидроксид железа 2.wmv");
                }
                if (btnName == "Mn")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Окислительные свойства диоксида марганца.wmv");
                }
                if (btnName == "Cu")
                {
                    Process.Start(Application.StartupPath + @"\files\video\Обнаружение меди.wmv");
                }

            }
            catch
            {
                MessageBox.Show(
                "Что -то пошло не так",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void moreVideoBtn2_Click(object sender, EventArgs e)
        {
            if (btnName == "Cu")
            {
                Process.Start(Application.StartupPath + @"\files\video\Сульфат меди.wmv");
            }

        }

        private void closeInfoBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
