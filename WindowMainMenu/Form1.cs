using CarNamespace;
using RepositoryNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowMainMenu
{
    public partial class Form1 : Form
    {
        Repository Repo = new Repository();

        public Form1()
        {
            InitializeComponent();
            button1.Text = "Add Car";
            button2.Text = "Show List";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Car c = new Car() { Brand = textBox1.Text, Model = textBox2.Text };
                Repo.Save(c);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Car c in Repo.myCarList)
            {
                listBox1.Items.Add(c.Brand);
            }
        }
    }
}
