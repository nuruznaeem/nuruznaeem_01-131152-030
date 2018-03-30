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
    public partial class top3 : Form
    {
        string way;
        public top3()
        {
            InitializeComponent();
        }

        private void top3_Load(object sender, EventArgs e)
        {
            search.Hide();
            topofclass.Hide();
            label1.Hide();
            sem1.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            way = path1.Text;
            sem1.Show();
            topofclass.Show();
            label1.Show();
            search.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            var listing = new List<String>();
            StreamReader find = new StreamReader(way);
            string check = "";
            while ((check = find.ReadLine()) != null)
            {
                int temp;
                int.TryParse(check, out temp);
                if (int.TryParse(check, out temp))
                    if ((sem1.Text == temp.ToString()))
                    {
                        string cgpa = find.ReadLine();
                        listing.Add(cgpa);
                        
                    }
            }
            string[] arr = listing.ToArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach (string thing in arr)
            {
                topofclass.Items.Add(thing);
            }
        }
    }
}
