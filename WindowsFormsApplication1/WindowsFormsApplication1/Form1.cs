using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_obi frmob = new frm_obi();
            frmob.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_obi frmob = new frm_obi();
            frmob.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_osi frmos = new Frm_osi();
            frmos.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_osi frmos = new Frm_osi();
            frmos.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_ike frmik = new frm_ike();
            frmik.ShowDialog();
        }
    }
}
