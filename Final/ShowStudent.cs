using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using FinalProject;
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
    public partial class ShowStudent : Form
    {
        DAL_SinhVien dal_sv = new DAL_SinhVien();

        public ShowStudent()
        {
            InitializeComponent();
            GUI_getDataForCombobox();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            QuanLySV qlsv = new QuanLySV();
            qlsv.Show();
            this.Visible = false;
        }

        public void GUI_getDataForCombobox()
        {


            cbbKhoa.ValueMember = "id";
            cbbKhoa.DisplayMember = "ma_khoa_hoc";
            cbbKhoa.DataSource = dal_sv.getDataForSelectBox("khoa_hoc");

            cbbCoQuan.ValueMember = "id";
            cbbCoQuan.DisplayMember = "ten_co_quan";
            cbbCoQuan.DataSource = dal_sv.getDataForSelectBox("co_quan");

            cbbNganh.ValueMember = "id";
            cbbNganh.DisplayMember = "ten_nganh";
            cbbNganh.DataSource = dal_sv.getDataForSelectBox("nganh_dao_tao");

            cbbNghe.ValueMember = "id";
            cbbNghe.DisplayMember = "ten_nganh";
            cbbNghe.DataSource = dal_sv.getDataForSelectBox("nganh_nghe");
        }

        public void setMaSV(string value)
        {
            txtMaSV.Text = value;
        }

        public void setHoTen(string value)
        {
            txtHoTen.Text = value;
        }

        public void setGioiTinh(string value)
        {
            cbbGioiTinh.SelectedIndex = cbbGioiTinh.FindStringExact(value);
        }

        public void setDanToc(string value)
        {
            cbbDanToc.SelectedIndex = cbbDanToc.FindStringExact(value);
        }

        public void setNgaySinh(string value)
        {
            dateNgaysinh.Value = DateTime.Parse(value);
        }

        public void setKhoa(string value)
        {
            cbbKhoa.SelectedIndex = cbbKhoa.FindStringExact(value);
        }

        public void setHocLuc(string value)
        {
            cbbHocLuc.SelectedIndex = cbbHocLuc.FindStringExact(value);
        }

        public void setNganh(string value)
        {
            cbbNganh.SelectedIndex = cbbNganh.FindStringExact(value);
        }

        public void setViecLam(string value)
        {
            cbbNghe.SelectedIndex = cbbNghe.FindStringExact(value);
        }

        public void setQueQuan(string value)
        {
            txtQueQuan.Text = value;
        }

        public void setCoQuan(string value)
        {
            cbbCoQuan.SelectedIndex = cbbCoQuan.FindStringExact(value);
        }

        private void btnQuayLai_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            QuanLySV qlsv = new QuanLySV();
            qlsv.Show();
        }
    }
}

