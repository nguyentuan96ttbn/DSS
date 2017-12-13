using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Final.ConnectDB;

namespace FinalProject
{
    class DAL_SinhVien : DBConnect
    {
        public DataTable getSinhVien()
        {
            //string sql = "SELECT ma_sinh_vien, ho_ten, ngay_sinh, dan_toc, gioi_tinh, hoc_luc, nganh_dao_tao.ten_nganh as ten_nganh_dao_tao, nganh_nghe as ten_nganh_lam_viec, khoa_hoc.khoa as khoa_hoc FROM sinh_vien Inner Join nganh_dao_tao on nganh_dao_tao.ma_nganh = sinh_vien.ma_nganh inner join khoa_hoc on khoa_hoc.khoa = sinh_vien.khoa where sinh_vien.nganh_nghe IS NULL";
            SqlDataAdapter da = new SqlDataAdapter("SELECT ma_sinh_vien, ho_ten, ngay_sinh, gioi_tinh, dan_toc, que_quan, khoa_hoc, hoc_luc, nganh_dao_tao.ten_nganh as ten_nganh_dao_tao, nganh_nghe.ten_nganh as ten_nganh_lam_viec, ten_co_quan FROM sinh_vien Inner Join nganh_dao_tao on nganh_dao_tao.ma_nganh = sinh_vien.ma_nganh_dao_tao inner join nganh_nghe on (nganh_nghe.ma_nganh = sinh_vien.ma_nganh_nghe)", _conn);
           
            DataTable dtSinhVien = new DataTable();
            da.Fill(dtSinhVien);
            return dtSinhVien;
        }

        public DataTable getDataForSelectBox(string str)
        {
            DataTable dtSinhVien = new DataTable();
           
            if (str == "nganh_dao_tao")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT distinct ma_nganh, ten_nganh from nganh_dao_tao", _conn);
                da.Fill(dtSinhVien);
                dtSinhVien.Columns.Add("Column1", typeof(string));
                DataRow dr;
                dr = dtSinhVien.NewRow();
                dr.ItemArray = new object[] { 0, "--Chọn ngành đào tạo--" };
                dtSinhVien.Rows.InsertAt(dr, 0);
            }
            else if (str == "nganh_nghe")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT distinct ma_nganh, ten_nganh from nganh_nghe", _conn);
                da.Fill(dtSinhVien);
                dtSinhVien.Columns.Add("Column1", typeof(string));
                DataRow dr;
                dr = dtSinhVien.NewRow();
                dr.ItemArray = new object[] { 0, "--Chọn ngành nghề--" };
                dtSinhVien.Rows.InsertAt(dr, 0);
            }
            else if (str == "khoa_hoc")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT distinct khoa from khoa_hoc", _conn);
                da.Fill(dtSinhVien);
                dtSinhVien.Columns.Add("Column1", typeof(string));
                DataRow dr;
                dr = dtSinhVien.NewRow();
                dr.ItemArray = new object[] { "--Chọn khóa học--", 0 };
                dtSinhVien.Rows.InsertAt(dr, 0);
            }
            else if (str == "co_quan")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT distinct ten_co_quan from co_quan", _conn);
                da.Fill(dtSinhVien);
                dtSinhVien.Columns.Add("Column1", typeof(string));
                DataRow dr;
                dr = dtSinhVien.NewRow();
                dr.ItemArray = new object[] { "--Chọn cơ quan--", 0 };
                dtSinhVien.Rows.InsertAt(dr, 0);
            }
            return dtSinhVien;
        }

        // Thêm sinh viên

        public bool themSinhVien(DTO_SinhVien sv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("INSERT INTO sinh_vien(ma_sinh_vien, ho_ten, ngay_sinh, gioi_tinh, dan_toc, que_quan, khoa_hoc, hoc_luc, ma_nganh_dao_tao, ma_nganh_nghe, ten_co_quan) VALUES ('{0}',N'{1}','{2}',N'{3}',N'{4}',N'{5}','{6}',N'{7}',N'{8}',N'{9}',N'{10}')", sv.MA_SV, sv.HO_TEN, sv.NGAY_SINH,sv.GIOI_TINH, sv.DAN_TOC, sv.QUE_QUAN,sv.KHOA, sv.HOC_LUC, sv.MA_NGANH, sv.NGANH_NGHE, sv.TEN_CO_QUAN);
                // Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi trong khi thêm mới!");
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }


        // Sửa sinh viên

        public bool suaSinhVien(DTO_SinhVien sv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE sinh_vien SET ma_sinh_vien= '{0}', ho_ten = N'{1}', ngay_sinh='{2}', gioi_tinh = N'{3}', dan_toc=N'{4}', que_quan=N'{5}', khoa_hoc = '{6}', hoc_luc = N'{7}', ma_nganh_dao_tao = '{8}', ma_nganh_nghe = '{9}',  ten_co_quan = N'{10}' WHERE ma_sinh_vien = '{11}'", sv.MA_SV, sv.HO_TEN, sv.NGAY_SINH, sv.GIOI_TINH, sv.DAN_TOC, sv.QUE_QUAN, sv.KHOA, sv.HOC_LUC, sv.MA_NGANH, sv.NGANH_NGHE, sv.TEN_CO_QUAN, sv.MA_SV);
                // Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi trong khi sửa!");
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        //Xóa sinh viên

        public bool xoaSinhVien(string SV_ID)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM sinh_vien WHERE ma_sinh_vien = '{0}'", SV_ID);

                // Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi trong khi xóa sinh viên!");
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }


    }
}
