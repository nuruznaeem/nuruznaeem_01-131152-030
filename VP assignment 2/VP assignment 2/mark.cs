using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VP_assignment_2
{
    public partial class mark : Form
    {
        string way;
        string way2;

        public mark()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Show();
            radioButton2.Show();
            sname.Show();
            StreamReader find = new StreamReader(way);
            string line;
            while ((line = find.ReadLine()) != null)
            {
                string id = line;
                string name = find.ReadLine();
                string sem1 = find.ReadLine();
                if (sem.Text == sem1)
                {
                    sname.Text = name;
                }
            }
        }

        private void mark_Load(object sender, EventArgs e)
        {
            radioButton1.Hide();
            radioButton2.Hide();
            sname.Hide();
            label4.Hide();
            next.Hide();
            path1.Hide();
            button1.Hide();
            sem.Hide();
            label3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            way = path2.Text;
            label4.Show();
            next.Show();
            path1.Show();
        }

        private void next_Click(object sender, EventArgs e)
        {
                way2 = path1.Text;
                MessageBox.Show("FILE MADE");
                button1.Show();
                sem.Show();
                label3.Show();
        }
    }
}
