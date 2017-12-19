using Final.ConnectDB;
using FinalProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class QuanLySV : Form
    {
        DAL_SinhVien dal_sv = new DAL_SinhVien();
        public QuanLySV()
        {
            InitializeComponent();
            addBranchToListBox();
            addAbilityToListBox();
            addCourseToListBox();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Visible = false;
        }
        public void GUI_SinhVien_Load(object sender, EventArgs e)
        {
            dgvStudent.DataSource = dal_sv.getSinhVien(); // get sinh vien
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddStudent add = new AddStudent();
            add.Show();
            this.Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EditStudent edit = new EditStudent();
            edit.Show();
            this.Visible = false;
            // Lấy thứ tự record hiện hành 
            int r = dgvStudent.CurrentCell.RowIndex; 
            // Lấy mã sinh viên của record hiện hành 
            string maSV = dgvStudent.Rows[r].Cells[0].Value.ToString();
            string hoten = dgvStudent.Rows[r].Cells[1].Value.ToString();
            string ngaysinh = dgvStudent.Rows[r].Cells[2].Value.ToString();
            string gioitinh = dgvStudent.Rows[r].Cells[3].Value.ToString();
            string dantoc = dgvStudent.Rows[r].Cells[4].Value.ToString();
            string quequan = dgvStudent.Rows[r].Cells[5].Value.ToString();
            string khoa = dgvStudent.Rows[r].Cells[6].Value.ToString();
            string hocluc = dgvStudent.Rows[r].Cells[7].Value.ToString();
            string nganh = dgvStudent.Rows[r].Cells[8].Value.ToString();
            string vieclam = dgvStudent.Rows[r].Cells[9].Value.ToString();
            string coquan = dgvStudent.Rows[r].Cells[10].Value.ToString();

            edit.setMaSV(maSV);
            edit.setHoTen(hoten);
            edit.setGioiTinh(gioitinh);
            edit.setDanToc(dantoc);
            edit.setNgaySinh(ngaysinh);
            edit.setKhoa(khoa);
            edit.setHocLuc(hocluc);
            edit.setNganh(nganh);
            edit.setViecLam(vieclam);
            edit.setQueQuan(quequan);
            edit.setCoQuan(coquan);

        }

        private int left = 3;
        private int top = 3;
        private int distance = 20;

        private void addBranchToListBox()
        {
            DBConnect db = new DBConnect();
            db._conn.Open();
            string SQL = string.Format("Select ten_nganh from nganh_dao_tao");
            // Command
            SqlCommand cmd = new SqlCommand(SQL, db._conn);
            SqlDataReader data = cmd.ExecuteReader();
            int i = 0;
            while (data.Read())
            {
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new System.Drawing.Point(left, top + distance * i);
                checkBox.Name = data.GetString(0);
                checkBox.Size = new System.Drawing.Size(80, 17);
                checkBox.TabIndex = 0;
                checkBox.Text = data.GetString(0);
                checkBox.UseVisualStyleBackColor = true;
                pnlNganh.Controls.Add(checkBox);
                i++;
            }
            db._conn.Close();
        }


        private void addAbilityToListBox()
        {
            string[] ability = new string[] { "Trung bình", "Khá", "Giỏi", "Xuất sắc" };
            for(int i = 0; i < ability.Length; i++)
            {
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new System.Drawing.Point(left, top + distance * i);
                checkBox.Name = "checkBoxHL";
                checkBox.Size = new System.Drawing.Size(80, 17);
                checkBox.TabIndex = 0;
                checkBox.Text = ability[i];
                checkBox.UseVisualStyleBackColor = true;
                pnlHocLuc.Controls.Add(checkBox);
            }
        }

        private void addCourseToListBox()
        {
            string[] course = new string[] { "K51", "K52", "K53", "K54", "K55", "K56" };
            for (int i = 0; i < course.Length; i++)
            {
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new System.Drawing.Point(left, top + distance * i);
                checkBox.Name = "checkBoxHL";
                checkBox.Size = new System.Drawing.Size(80, 17);
                checkBox.TabIndex = 0;
                checkBox.Text = course[i];
                checkBox.UseVisualStyleBackColor = true;
                pnlKhoa.Controls.Add(checkBox);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?.", "Xác nhận xóa", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                // Lấy thứ tự record hiện hành
                int r = dgvStudent.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string maSV = dgvStudent.Rows[r].Cells[0].Value.ToString();
                if (dal_sv.xoaSinhVien(maSV))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvStudent.DataSource = dal_sv.getSinhVien(); // load lại table
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
            }
           
        }

        private void quickFilter_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db._conn.Open();
            //string union_sql = "SELECT ma_sinh_vien, ho_ten, ngay_sinh, dan_toc, gioi_tinh, hoc_luc, nganh_dao_tao.ten_nganh as ten_nganh_dao_tao, nganh_nghe as ten_nganh_lam_viec, khoa_hoc.khoa as khoa_hoc FROM sinh_vien Inner Join nganh_dao_tao on nganh_dao_tao.ma_nganh = sinh_vien.ma_nganh inner join khoa_hoc on khoa_hoc.khoa = sinh_vien.khoa where sinh_vien.nganh_nghe IS NULL";
            string sql = "SELECT ma_sinh_vien, ho_ten, ngay_sinh, gioi_tinh, dan_toc, que_quan, ma_khoa_hoc, hoc_luc, nganh_dao_tao.ten_nganh as ten_nganh_dao_tao, nganh_nghe.ten_nganh as ten_nganh_lam_viec, ten_co_quan FROM sinh_vien Inner Join nganh_dao_tao on nganh_dao_tao.ma_nganh_dao_tao = sinh_vien.ma_nganh_dao_tao inner join nganh_nghe on (nganh_nghe.ma_nganh_nghe = sinh_vien.ma_nganh_nghe) AND 1 = 1";
            string gioitinh = "";
            if(cbbGioiTinh.Text == ""){
                gioitinh = "";
            }
            else {
                gioitinh = cbbGioiTinh.SelectedItem.ToString();
            }

            if (gioitinh == "")
            {
                sql += " ";
            }
            else
            {
                if(gioitinh == "Cả hai")
                {
                    sql += " AND (gioi_tinh = 'Nam' OR gioi_tinh = N'Nữ')";
                }
                else
                {
                    sql += " AND gioi_tinh = N'" +gioitinh+"'";
                }
            }

            string dantoc = "";
            if(cbbDanToc.Text == "")
            {
                dantoc = "";
            }
            else
            {
                dantoc = cbbDanToc.SelectedItem.ToString();
            }

            if(dantoc == "")
            {
                sql += " ";
            }
            else
            {
                if (dantoc == "Cả hai")
                {
                    sql += " AND (dan_toc = 'Kinh' OR dan_toc = 'Khác')";
                }
                else
                {
                    sql += " AND dan_toc = '" + dantoc+"'";
                }
            }

            string vieclam = "";
            if(cbbViecLam.Text == "")
            {
                vieclam = "";
            }
            else
            {
                vieclam = cbbViecLam.SelectedItem.ToString();
            }

            if(vieclam == "")
            {
                sql += " ";
            }
            else
            {
                if(vieclam == "Cả hai")
                {
                    sql += " AND (nganh_nghe.ten_nganh IS NULL OR nganh_nghe.ten_nganh IS NOT NULL)";
                }
                else if(vieclam == "Đã có việc làm")
                {
                    sql += " AND nganh_nghe.ten_nganh IS NOT NULL";

                }
                else if(vieclam == "Chưa có việc làm")
                {
                    sql += " AND nganh_nghe.ten_nganh IS NULL";
                }
            }

            //get data nganh_dao_tao in listbox
            string s = "";
            foreach (Control c in pnlNganh.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                {
                    s += c.Text +",";
                }
            }

            char[] delimiterChars = { ',' };
            if(s == "")
            {
                sql += "";
            }
            else
            {
                string[] nganh_dao_tao = s.Split(delimiterChars);
                if (nganh_dao_tao.Length == 1)
                {
                    sql += " AND nganh_dao_tao.ten_nganh = N'" + nganh_dao_tao[0] + "'";
                }
                else
                {
                    sql += " AND (nganh_dao_tao.ten_nganh = N'" + nganh_dao_tao[0] + "'";
                    for (int i = 1; i < nganh_dao_tao.Length; i++)
                    {
                        sql += " OR nganh_dao_tao.ten_nganh = N'" + nganh_dao_tao[i] + "'";
                    }
                    sql += ")";
                }
            }
            

            //get data hoc_luc in listbox
            string str = "";
            foreach (Control c in pnlHocLuc.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                {
                    str += c.Text + ",";
                }
            }
            if (str == "")
            {
                sql += "";
            }
            else
            {
                string[] hoc_luc = str.Split(delimiterChars);
                if (hoc_luc.Length == 1)
                {
                    sql += " AND hoc_luc = N'" + hoc_luc[0] + "'";
                }
                else
                {
                    sql += " AND (hoc_luc = N'" + hoc_luc[0] + "'";
                    for (int i = 1; i < hoc_luc.Length; i++)
                    {
                        sql += " OR hoc_luc = N'" + hoc_luc[i] + "'";
                    }
                    sql += ")";
                }
            }

            //get data khoa hoc in listbox
            string strKH = "";
            foreach (Control c in pnlKhoa.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                {
                    if(c.Text == "K51")
                    {
                        strKH += "QH.2006.T.,";
                    }
                    else if (c.Text == "K52")
                    {
                        strKH += "QH.2007.T.,";
                    }
                    else if (c.Text == "K53")
                    {
                        strKH += "QH.2008.T.,";
                    }
                    else if (c.Text == "K54")
                    {
                        strKH += "QH.2009.T.,";
                    }
                    else if (c.Text == "K55")
                    {
                        strKH += "QH.2010.T.,";
                    }
                    else if (c.Text == "K56")
                    {
                        strKH += "QH.2011.T.,";
                    }
                }
            }

            if (strKH == "")
            {
                sql += "";
            }
            else
            {
                string[] khoa_hoc = strKH.Split(delimiterChars);
                if (khoa_hoc.Length == 1)
                {
                    sql += " AND ma_khoa_hoc = N'" + khoa_hoc[0] + "'";
                }
                else
                {
                    sql += " AND (ma_khoa_hoc = N'" + khoa_hoc[0] + "'";
                    for (int i = 1; i < khoa_hoc.Length; i++)
                    {
                        sql += "OR ma_khoa_hoc = N'" + khoa_hoc[i] + "'";
                    }
                    sql += ")";
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(sql, db._conn);
            DataTable dtSinhVien = new DataTable();
            da.Fill(dtSinhVien);
            dgvStudent.DataSource = dtSinhVien ;
            db._conn.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = dal_sv.getSinhVien(); // load lại table
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ShowStudent show = new ShowStudent();
            show.Show();
            this.Visible = false;
            // Lấy thứ tự record hiện hành 
            int r = dgvStudent.CurrentCell.RowIndex;
            // Lấy mã sinh viên của record hiện hành 
            string maSV = dgvStudent.Rows[r].Cells[0].Value.ToString();
            string hoten = dgvStudent.Rows[r].Cells[1].Value.ToString();
            string ngaysinh = dgvStudent.Rows[r].Cells[2].Value.ToString();
            string gioitinh = dgvStudent.Rows[r].Cells[3].Value.ToString();
            string dantoc = dgvStudent.Rows[r].Cells[4].Value.ToString();
            string quequan = dgvStudent.Rows[r].Cells[5].Value.ToString();
            string khoa = dgvStudent.Rows[r].Cells[6].Value.ToString();
            string hocluc = dgvStudent.Rows[r].Cells[7].Value.ToString();
            string nganh = dgvStudent.Rows[r].Cells[8].Value.ToString();
            string vieclam = dgvStudent.Rows[r].Cells[9].Value.ToString();
            string coquan = dgvStudent.Rows[r].Cells[10].Value.ToString();

            show.setMaSV(maSV);
            show.setHoTen(hoten);
            show.setGioiTinh(gioitinh);
            show.setDanToc(dantoc);
            show.setNgaySinh(ngaysinh);
            show.setKhoa(khoa);
            show.setHocLuc(hocluc);
            show.setNganh(nganh);
            show.setViecLam(vieclam);
            show.setQueQuan(quequan);
            show.setCoQuan(coquan);
        }
    }
}
