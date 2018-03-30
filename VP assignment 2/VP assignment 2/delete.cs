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
    public partial class delete : Form
    {
        string Way;
        public delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Way = path.Text;
            StreamReader find = new StreamReader(Way);
            string line;
            int increment = 0;
            while ((line = find.ReadLine()) != null)
            {
                increment += 1;
            }
            find.Close();
            find = new StreamReader(Way);
            string[] occupy = new string[increment];
            for (int i = 0; i < increment; i++)
            {
                occupy[i] = find.ReadLine();
                if (occupy[i] == id.Text)
                {
                    occupy[i] = null;
                    i--;
                    for (int j = 0; j < 5; j++)
                    {
                        line = find.ReadLine();
                    }
                }
            }
            find.Close();
            using (StreamWriter nextfile = new StreamWriter(Way))
            {
                for (int i = 0; i < occupy.Length; i += 1)
                {
                    nextfile.WriteLine(occupy[i]);
                }
            }
            MessageBox.Show("DONE DELETING");
        }

        private void delete_Load(object sender, EventArgs e)
        {
            label2.Hide();
            id.Hide();
            deletefunct.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            Way = path.Text;
            if (File.Exists(Way))
            {
                label2.Show();
                id.Show();
                deletefunct.Show();
            }
            else
            {
                MessageBox.Show("FILE DOESNOT EXIST(PLEASE CREATE AND WRITE ONE)");
                Application.Exit();
            }
        }

        private void path_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
