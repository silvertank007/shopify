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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel4.Visible = true;
            //abc123 xyzpqra git seems to be great
            //so  how you do it is mentioned here (view -> team explorer -> changes -> add what you did in comment -> commit all ->)
            this.Close();
            Form1 f1 = new Form1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel4.Visible = false;
        }
    }
}
