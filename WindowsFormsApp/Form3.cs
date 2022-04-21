using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        private Form1 _form1;

        public Form3(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && int.TryParse(textBox1.Text, out int min) &&
                int.TryParse(textBox2.Text, out int max))
            {
                if (radioButton1.Checked)
                {
                    _form1.FindFromList("Книга", min, max);
                    Close();
                }
                if (radioButton2.Checked)
                {
                    _form1.FindFromList("Журнал", min, max);
                    Close();
                }
                if (radioButton3.Checked)
                {
                    _form1.FindFromList("Сборник", min, max);
                    Close();
                }
            }
            else MessageBox.Show("Заполните все поля корректно");
        }
    }
}
