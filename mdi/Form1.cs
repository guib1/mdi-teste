using Form2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void janelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Form2.Form2 newMDIChild = new Form2.Form2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();


        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2.Form2 newMDIChild = new Form2.Form2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
    }
}
