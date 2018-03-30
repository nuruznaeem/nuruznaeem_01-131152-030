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
    public partial class write : Form
    {
        string path;
        public write()
        {
            InitializeComponent();
        }

        private void write_Load(object sender, EventArgs e)
        {
            sname.Hide();
            sid.Hide();
            ssem.Hide();
            suni.Hide();
            scgpa.Hide();
            sdept.Hide();
            id.Hide();
            name.Hide();
            cgpa.Hide();
            semester.Hide();
            dept.Hide();
            uni.Hide();
            done.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void done_Click(object sender, EventArgs e)
        {
            using (StreamWriter txt = File.AppendText(path))
            {
                txt.WriteLine(sid.Text);
                sid.Clear();
                txt.WriteLine(sname.Text);
                sname.Clear();
                txt.WriteLine(ssem.Text);
                ssem.Clear();
                txt.WriteLine(scgpa.Text);
                scgpa.Clear();
                txt.WriteLine(sdept.Text);
                sdept.Clear();
                txt.WriteLine(suni.Text);
                suni.Clear();
                MessageBox.Show("WRITE COMPLETED");
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            path = Path.Text;
            Path.Clear();
            sname.Show();
            name.Show();
            sid.Show();
            id.Show();
            ssem.Show();
            semester.Show();
            scgpa.Show();
            cgpa.Show();
            sdept.Show();
            dept.Show();
            suni.Show();
            uni.Show();
            done.Show();
        }
    }
}
