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
    public partial class bysem : Form
    {
        string way;
        public bysem()
        {
            InitializeComponent();
        }
        private void search_Click(object sender, EventArgs e)
        {
            bool check = false;
            List<string> get = new List<string>();
            StreamReader find = new StreamReader(way);
            string list = "";
            while ((list = find.ReadLine()) != null)
            {
                string id = list;
                string name=find.ReadLine();
                string sem=find.ReadLine();
                if ((sem1.Text == sem))
                {
                    check = true;
                    semrecord.Items.Add(id);
                    semrecord.Items.Add(name);
                    semrecord.Items.Add(sem1.Text);
                    string cgpa = find.ReadLine();
                    semrecord.Items.Add(cgpa);
                    string dept = find.ReadLine();
                    semrecord.Items.Add(dept);
                    string uni = find.ReadLine();
                    semrecord.Items.Add(uni);
                }
            }
            if (check == false)
            {
                Console.WriteLine("Couldnot Find such semester");
            }
        }
        private void bysem_Load(object sender, EventArgs e)
        {
            search.Hide();
            semrecord.Hide();
            label1.Hide();
            sem1.Hide();
        }
        private void next_Click(object sender, EventArgs e)
        {
            way = path1.Text;
            if (File.Exists(way))
            {
                path1.Hide();
                label2.Hide();
                next.Hide();
                sem1.Show();
                search.Show();
                semrecord.Show();
                label1.Show();
            }
            else
            {
                MessageBox.Show("FILE DOESNOT EXIST(PLEASE CREATE AND WRITE ONE)");
                Application.Exit();
            }
        }
    }
}