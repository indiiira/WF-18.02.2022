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

namespace 18.02.2022
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void Form3_Load(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

       

       

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text=="09-121")
            {
               foreach (var line in File.ReadLines(""))
                {
                    var array = line.Split();
                    dataGridView1.Rows.Add(array);
                }
            }
           if (e.Node.Text == "09-122")
            {
                dataGridView1.Rows.Add("Gradenko O O", "25", "New York");
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
