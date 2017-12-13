using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class DTO_SinhVien
    {
        private string _MA_SV;
        private string _HO_TEN;
        private string _NGAY_SINH;
        private string _DAN_TOC;
        private string _GIOI_TINH;
        private string _HOC_LUC;
        private string _MA_NGANH;
        private string _KHOA;
        private string _NGANH_NGHE;
        private string _QUE_QUAN;
        private string _TEN_CO_QUAN;

        public DTO_SinhVien(string MA_SV, string HO_TEN, string NGAY_SINH,string GIOI_TINH, string DAN_TOC ,string QUE_QUAN, string KHOA, string HOC_LUC, string MA_NGANH, string NGANH_NGHE, string TEN_CO_QUAN)
        {
            _MA_SV = MA_SV;
            _HO_TEN = HO_TEN;
            _NGAY_SINH = NGAY_SINH;
            _DAN_TOC = DAN_TOC;
            _GIOI_TINH = GIOI_TINH;
            _HOC_LUC = HOC_LUC;
            _MA_NGANH = MA_NGANH;
            _KHOA = KHOA;
            _NGANH_NGHE = NGANH_NGHE;
            _QUE_QUAN = QUE_QUAN;
            _TEN_CO_QUAN = TEN_CO_QUAN;

        }

        /* ======== GETTER/SETTER ======== */
        public string MA_SV
        {
            get
            {
                return _MA_SV;
            }

            set
            {
                _MA_SV = value;
            }
        }

        public string HO_TEN
        {
            get
            {
                return _HO_TEN;
            }

            set
            {
                _HO_TEN = value;
            }
        }
        public string NGAY_SINH
        {
            get
            {
                return _NGAY_SINH;
            }

            set
            {
                _NGAY_SINH = value;
            }
        }
        public string DAN_TOC
        {
            get
            {
                return _DAN_TOC;
            }

            set
            {
                _DAN_TOC = value;
            }
        }
        public string GIOI_TINH
        {
            get
            {
                return _GIOI_TINH;
            }

            set
            {
                _GIOI_TINH = value;
            }
        }
        public string HOC_LUC
        {
            get
            {
                return _HOC_LUC;
            }

            set
            {
                _HOC_LUC = value;
            }
        }
        public string MA_NGANH
        {
            get
            {
                return _MA_NGANH;
            }

            set
            {
                _MA_NGANH = value;
            }
        }
        public string KHOA
        {
            get
            {
                return _KHOA;
            }

            set
            {
                _KHOA = value;
            }
        }
        public string NGANH_NGHE
        {
            get
            {
                return _NGANH_NGHE;
            }

            set
            {
                _NGANH_NGHE = value;
            }
        }
        public string QUE_QUAN
        {
            get
            {
                return _QUE_QUAN;
            }

            set
            {
                _QUE_QUAN = value;
            }
        }
        public string TEN_CO_QUAN
        {
            get
            {
                return _TEN_CO_QUAN;
            }

            set
            {
                _TEN_CO_QUAN = value;
            }
        }
    }
}
