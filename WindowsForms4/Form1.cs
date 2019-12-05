using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms4
{
    public partial class Form1 : Form
    {

        string fl1 = @"C:\Users\Pro100Elite\Desktop\kosty3.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rr(result("Проверка завершена", "Ответ"));
        }

        string Slovo(string str, string str2) // свойство
        {
            return $" Файл\n {str} {str2} существует";
        }

        bool _Bool(string line) // свойство
        {
            return File.Exists(line) ? true : false;
        }

        DialogResult result(string str, string str2) // свойство
        {
            return MessageBox.Show(str, str2, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void Rr(DialogResult result) // метод
        {
            if (DialogResult.OK == result)
            {
                label1.Text = _Bool(fl1) ? Slovo($"{fl1}", null) : Slovo($"{fl1}", "не");
            }
        }
    }
}
