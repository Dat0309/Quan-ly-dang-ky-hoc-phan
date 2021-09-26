using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDangKyHocPhan.Model;

namespace QuanLyDangKyHocPhan.Data
{
    public interface IDataSourceHP
    {
        List<HocPhan> GetHP();
        void Save(List<HocPhan> hp);
    }
}
