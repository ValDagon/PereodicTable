using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;


namespace Pereodic_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CommonBtn_Click(object sender, EventArgs e)
        {
            string fileName = "files/text/" + (sender as Button).Name + ".txt";

            try
            {
                StreamReader streamReader = new StreamReader(fileName); //Открываем файл для чтения

                string str = ""; //Объявляем переменную, в которую будем записывать текст из файла

                while (!streamReader.EndOfStream) //Цикл длиться пока не будет достигнут конец файла
                {
                    str += streamReader.ReadLine(); //В переменную str по строчно записываем содержимое файла
                }

                MessageBox.Show(str);
            }
            catch
            {
                MessageBox.Show("Ошибка! Файл ещё не создан!");
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
                     

    }
}
