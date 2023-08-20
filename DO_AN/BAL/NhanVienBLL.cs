using DO_AN.DAL;
using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.BAL
{
    internal class NhanVienBLL
    {
        NhanVienDAL dal = new NhanVienDAL();
        public List<NhanVien> ReadNhanVien()
        {
            List<NhanVien> lstCus = dal.ReadNhanVien();
            return lstCus;
        }
        public void NewNhanVien(NhanVien cus)
        {
            dal.NewNhanVien(cus);
        }
        public void DeleteNhanVien(NhanVien cus)
        {
            dal.DeleteNhanVien(cus);
        }
        public void EditNhanVien(NhanVien cus)
        {
            dal.EditNhanVien(cus);
        }
        public void LuuNhanVien(NhanVien cus)
        {
            dal.LuuNhanVien(cus);
        }
    }
}
