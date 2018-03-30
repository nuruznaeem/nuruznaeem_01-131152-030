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
    public partial class byname : Form
    {
        string way;
        public byname()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            way = path2.Text;
            if (File.Exists(way))
            {
                path2.Hide();
                label2.Hide();
                next.Hide();
                label1.Show();
                name.Show();
                search.Show();
                namerecord.Show();
            }
            else
            {
                MessageBox.Show("FILE DOESNOT EXIST(PLEASE CREATE AND WRITE ONE)");
                Application.Exit();
            }
        }

        private void byname_Load(object sender, EventArgs e)
        {
            label1.Hide();
            name.Hide();
            search.Hide();
            namerecord.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            bool check = false;
            StreamReader find = new StreamReader(way);
            string list = "";
            while ((list = find.ReadLine()) != null)
            {
                string id = list;
                if ((list = find.ReadLine()) == name.Text)
                {
                    check = true;
                    namerecord.Items.Add(id);
                    namerecord.Items.Add(name.Text); 
                    string sem = find.ReadLine();
                    namerecord.Items.Add(sem); 
                    string cgpa = find.ReadLine();
                    namerecord.Items.Add(cgpa); 
                    string dept = find.ReadLine();
                    namerecord.Items.Add(dept); 
                    string uni = find.ReadLine();
                    namerecord.Items.Add(uni); 
                }
            }
            if (check == false)
            {
                Console.WriteLine("couldnot find such name in the file");
            }
        }
    }
}
