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
    public partial class introduction : Form
    {
        public introduction()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            write f2 = new write();
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            top3 form = new top3();
            form.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            search f3 = new search();
            f3.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            mark f2 = new mark();
            f2.Show();
            this.Hide();
        }
        private void top3_Click(object sender, EventArgs e)
        {
            delete f2 = new delete();
            f2.Show();
            this.Hide();
        }
        private void view_Click(object sender, EventArgs e)
        {
            this.Hide();
            write f2 = new write();
            f2.Hide();
        }
    }
}