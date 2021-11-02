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
        private static Context _singleObject;
        private List<SinhVien> dssv;
        private IDataSource dataSource;
        private List<HocPhan> dshp;
        private IDataSourceHP dataSourceHP;

        private Context(IDataSource dataSource, IDataSourceHP dataSourceHP)
        {
            this.dataSource = dataSource;
            this.dataSourceHP = dataSourceHP;
        }

        public static Context gettInstance(IDataSource dataSource, IDataSourceHP dataSourceHP)
        {
            if (_singleObject == null)
            {
                _singleObject = new Context(dataSource,dataSourceHP);
            }
            return _singleObject;
        }

        public List<SinhVien> GetSV()
        {
            if (dssv == null)
                dssv = dataSource.GetSV();
            return dssv;
        }
        public List<HocPhan> GetHP()
        {
            if (dshp == null)
                dshp = dataSourceHP.GetHP();
            return dshp;
        }
        public void SaveSV()
        {
            dataSource.Save(dssv);
        }
        public void SaveHP()
        {
            dataSourceHP.Save(dshp);
        }
    }
}
