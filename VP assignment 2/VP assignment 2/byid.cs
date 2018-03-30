using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_assignment_2
{
    public partial class byid : Form
    {
        string way;
        public byid()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void next_Click(object sender, EventArgs e)
        {
            way = path1.Text;
            if (File.Exists(way))
            {
                path1.Hide();
                label2.Hide();
                next.Hide();
                ids.Show();
                idrecord.Show();
                label1.Show();
                search.Show();
            }
            else
            {
                MessageBox.Show("FILE DOESNOT EXIST(PLEASE CREATE AND WRITE ONE)");
                Application.Exit();
            }
        }
        private void byid_Load(object sender, EventArgs e)
        {
            ids.Hide();
            idrecord.Hide();
            label1.Hide();
            search.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            bool check = false;
            StreamReader find = new StreamReader(way);
            string line = "";
            while ((line = find.ReadLine()) != null)
            {
                int temp;
                int.TryParse(line, out temp);
                if (int.TryParse(line, out temp))
                {     
                    if (ids.Text==temp.ToString())
                    {
                        check = true;
                        idrecord.Items.Add(ids.Text);
                        string name = find.ReadLine();
                        idrecord.Items.Add(name);
                        int sem = int.Parse(find.ReadLine());
                        idrecord.Items.Add(sem);
                        float cgpa = float.Parse(find.ReadLine());
                        idrecord.Items.Add(cgpa); 
                        string dept = find.ReadLine();
                        idrecord.Items.Add(dept);
                        string uni = find.ReadLine();
                        idrecord.Items.Add(uni);
                    }
                }
            }
            if (check == false)
            {
                MessageBox.Show("Couldnot Find such ID");
            }
        }
    }
}
