using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
                int.TryParse(textBox2.Text, out int pages))
            {
                if (radioButton1.Checked)
                {
                    form1.AddToList(new Book(textBox1.Text, pages, textBox3.Text));
                }
                if (radioButton2.Checked)
                {
                    form1.AddToList(new Journal(textBox1.Text, pages, textBox3.Text));
                }
                if (radioButton3.Checked)
                {
                    form1.AddToList(new Digest(textBox1.Text, pages, textBox3.Text));
                }
            }
            else MessageBox.Show("Заполните поля корректно");
        }
    }
}
