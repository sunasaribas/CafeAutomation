using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CafeOtomasyonu.MENU
{
    public partial class frmLock : Form
    {
        public frmLock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGiris frm = new frmGiris();
            this.Close();
            frm.Show();
        }
    }
}
