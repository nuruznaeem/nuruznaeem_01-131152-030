using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_assignment_2
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void bid_Click(object sender, EventArgs e)
        {
            this.Dispose();
            byid f3 = new byid();
            f3.ShowDialog();
        }
        private void bname_Click(object sender, EventArgs e)
        {
            this.Dispose();
            byname f3 = new byname();
            f3.ShowDialog();
        }
        private void ssem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            bysem f3 = new bysem();
            f3.ShowDialog();
        }
    }
}
