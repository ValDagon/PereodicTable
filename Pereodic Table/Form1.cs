using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Pereodic_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        public void CommonBtn_Click(object sender, EventArgs e)
        {
            string fileName = Application.StartupPath + @"\files\text\" + (sender as Button).Name + ".html";
            string videoName = Application.StartupPath + @"\files\video\" + (sender as Button).Name + ".wmv";
            string titleName = (sender as Button).Name;

            try //Обрабатываем возможные ошибки
            {
                StreamReader streamReader = new StreamReader(fileName); //Открываем файл для чтения

                string str = "";

                while (!streamReader.EndOfStream) //Цикл длиться пока не будет достигнут конец файла
                {
                    str += streamReader.ReadLine(); //В переменную str по строчно записываем содержимое файла
                }
                Form2 f2 = new Form2(str, titleName, fileName, videoName);
                f2.Show();

            }
            catch
            {
                MessageBox.Show(
                    "Информация об элементе ещё не добавлена",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in this.Controls) //обходим все элементы формы
            {
                if (item is Button) // проверяем, что это кнопка
                {
                    ((Button)item).Click += CommonBtn_Click; //приводим к типу и устанавливаем обработчик события  
                }
            }
        }
                     
        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = SystemColors.ButtonHighlight;
        }

        private void OnMouseLeave1(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.PaleVioletRed;
        }

        private void OnMouseLeave2(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Orange;
        }

        private void OnMouseLeave3(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.RoyalBlue;
        }

        private void OnMouseLeave4(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.ForestGreen;
        }
    }
}


