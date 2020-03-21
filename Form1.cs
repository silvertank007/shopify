using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oep_dotnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            Form2 f2 = new Form2();
            f2.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            panel3.Visible = true;
            panel2.Visible = false;
            panel4.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
