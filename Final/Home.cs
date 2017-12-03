using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            QuanLySV Ql = new QuanLySV();
            this.Visible = false;
            Ql.ShowDialog();
           


        }

        private void btnTuVan_Click(object sender, EventArgs e)
        {
            TuVan Tv = new TuVan();
            this.Visible = false;
            Tv.ShowDialog();
            
        }
    }
}
