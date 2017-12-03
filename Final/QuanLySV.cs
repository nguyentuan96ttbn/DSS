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
    public partial class QuanLySV : Form
    {
        public QuanLySV()
        {
            InitializeComponent();
        }

        private void table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Visible = false;
        }
    }
}
