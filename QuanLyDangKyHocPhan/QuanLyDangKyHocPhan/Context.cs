using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDangKyHocPhan.Model;
using QuanLyDangKyHocPhan.Data;

namespace QuanLyDangKyHocPhan
{
    public class Context
    {
        private List<SinhVien> dssv;
        private IDataSource dataSource;

        public Context(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }
        public List<SinhVien> GetSV()
        {
            if (dssv == null)
                dssv = dataSource.GetSV();
            return dssv;
        }
        public void SaveSV()
        {
            dataSource.Save(dssv);
        }
    }
}
