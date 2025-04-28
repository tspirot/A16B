using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A16B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            this.Close();
        }
    }
}
