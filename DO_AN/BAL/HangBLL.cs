using DO_AN.DAL;
using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DO_AN.DAL.LoginDAL;

namespace DO_AN.BAL
{
    internal class HangBLL
    {
        HangDAL dal = new HangDAL();

        public List<Hang> ReadHang()
        {
            List<Hang> lstHang = dal.ReadHang();
            return lstHang;
        }

        public void NewHang(Hang hang)
        {
            dal.NewHang(hang);
        }

        public void DeleteHang(Hang hang)
        {
            dal.DeleteHang(hang);
        }

        public void EditHang(Hang hang)
        {
            dal.EditHang(hang);
        }
        public List<Hang> SearchHangByMaAndTen(string maHang, string tenHang)
        {
            List<Hang> searchResults = dal.SearchHangByMaAndTen(maHang, tenHang);
            return searchResults;
        }



    }
}
