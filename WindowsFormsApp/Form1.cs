using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private readonly List<Lib> _list = new List<Lib>();
        private readonly Random _rnd = new Random();

        public void AddToList(Lib item)
        {
            _list.Add(item);
            dataGridView1.Rows.Add(item.LibName, item.Format());
        }

        public void FindFromList(string libname, int min, int max)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in _list)
            {
                if (item.LibName == libname && item.Pages >= min && item.Pages <= max)
                {
                    dataGridView1.Rows.Add(item.LibName, item.Format());
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(this);
            frm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _list.RemoveAt(dataGridView1.SelectedRows[0].Index);
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка, невозможно удалить пустую строку, выберите данные.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sw = _rnd.Next(3);

            switch (sw)
            {
                case 0:
                    AddToList(new Book(RandomString(_rnd.Next(10)), _rnd.Next(1, 10), RandomString(_rnd.Next(10))));
                    break;
                case 1:
                    AddToList(new Journal(RandomString(_rnd.Next(10)), _rnd.Next(1, 10), RandomString(_rnd.Next(10))));
                    break;
                case 2:
                    AddToList(new Digest(RandomString(_rnd.Next(10)), _rnd.Next(1, 10), RandomString(_rnd.Next(10))));
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
                FileStream file = File.Create(saveFileDialog1.FileName);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(file, _list);
                file.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                FileStream file = File.OpenRead(openFileDialog1.FileName);
                BinaryFormatter formatter = new BinaryFormatter();
                IList<Lib> libs = formatter.Deserialize(file) as IList<Lib>;
                _list.Clear();
                dataGridView1.Rows.Clear();

                if (libs != null)
                {
                    foreach (var lib in libs)
                    {
                        AddToList(lib);
                    }
                }
                file.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this);
            frm3.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var lib in _list)
            {
                dataGridView1.Rows.Add(lib.LibName, lib.Format());
            }
        }

        public string RandomString(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[_rnd.Next(s.Length)]).ToArray());
        }
    }
}
