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
    public partial class EditStudent : Form
    {
        DAL_SinhVien dal_sv = new DAL_SinhVien();

        public EditStudent()
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtMaSV.Text != "")
            {
                //Nganh
                DataRowView drvNganh = cbbNganh.SelectedItem as DataRowView;
                string nganh = string.Empty;

                if (drvNganh != null)
                {
                    nganh = drvNganh.Row["ma_nganh_dao_tao"] as string;
                }

                //Nghe
                DataRowView drvNghe = cbbNghe.SelectedItem as DataRowView;
                string nghe = string.Empty;

                if (drvNghe != null)
                {
                    nghe = drvNghe.Row["ma_nganh_nghe"] as string;
                }

                //Dan toc
                string dantoc = cbbDanToc.SelectedItem.ToString();
                //Hoc luc
                string hocluc = cbbHocLuc.SelectedItem.ToString();

                //Gioi tinh
                string gioitinh = cbbGioiTinh.SelectedItem.ToString();

                //Quê quán
                string quequan = txtQueQuan.Text;

                //Cơ quan
                DataRowView drvCoquan = cbbCoQuan.SelectedItem as DataRowView;
                string coquan = string.Empty;

                if (drvCoquan != null)
                {
                    coquan = drvCoquan.Row["ten_co_quan"] as string;
                }

                //Khoa
                DataRowView drvKhoa = cbbKhoa.SelectedItem as DataRowView;
                string khoahoc = string.Empty;

                if (drvKhoa != null)
                {
                    khoahoc = drvKhoa.Row["ma_khoa_hoc"] as string;
                }

                // Tạo DTo
                DTO_SinhVien sv = new DTO_SinhVien(txtMaSV.Text, txtHoTen.Text, dateNgaysinh.Text, gioitinh, dantoc, quequan, khoahoc, hocluc, nganh, nghe, coquan);
                // Them
                if (dal_sv.suaSinhVien(sv))
                {
                    MessageBox.Show("Sửa thành công");
                    this.Visible = false;
                    QuanLySV qlsv = new QuanLySV();
                    qlsv.Show();
                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
    }
}
