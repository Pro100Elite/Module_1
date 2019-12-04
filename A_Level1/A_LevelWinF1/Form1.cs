using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A_Level;

namespace A_LevelWinF1
{
    public partial class Form1 : Form
    {
        DiscriminantAndSqrt1 Dis;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if (!double.TryParse(textBox1.Text, out Dis.a))
            {
                MessageBox.Show("Введите вещественнoe числo A", "ОЙ ВЕЙ!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = null;
                ok = false;
            } 
            else if (Dis.a == 0)
            {
                MessageBox.Show("Числo A не может быть 0", "ОЙ ВЕЙ!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = null;
                ok = false;
            }

            if (!double.TryParse( textBox2.Text, out Dis.b ))
            {
                MessageBox.Show("Введите вещественнoe числo B", "ОЙ ВЕЙ!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = null;
                ok = false;
            }

            if (!double.TryParse(textBox3.Text, out Dis.c))
            {
                MessageBox.Show("Введите вещественнoe числo C", "ОЙ ВЕЙ!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = null;
                ok = false;
            }

            if (ok)
            {

                Dis.Decision();
                if (Dis.d < 0)
                {
                    label1.Text = "Нет корней";
                    label5.Text = null;
                }
                else if (Dis.b == 0)
                {
                    label1.Text = $"x1 = {Dis.x1}";
                    label5.Text = null;
                }
                else
                {
                    label1.Text = $"x1 = {Dis.x1},\nx2 = {Dis.x2}";
                    label5.Text = Dis.LineUrForm().Replace("--", "+");
                }
            }
        }
    }
}
