using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDangKyHocPhan.Model;
using System.IO;

namespace QuanLyDangKyHocPhan.Data
{
    public class SVDataSource : IDataSource
    {
        private string fileName;

        public SVDataSource(string fileName)
        {
            this.fileName = fileName;
        }

        public List<SinhVien> GetSV()
        {
            List<SinhVien> sv = new List<SinhVien>();
            if (File.Exists(fileName)){
                using (var reader = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read)))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        var sinhvien = ParseSV(line);
                        sv.Add(sinhvien);
                    }
                }
            }
            return sv;
        }

        public void Save(List<SinhVien> sv)
        {
            throw new NotImplementedException();
        }

        private SinhVien ParseSV(string line)
        {
            var parts = line.Split('*');
            return new SinhVien()
            {
                mssv = parts[0],
                ho = parts[1],
                ten = parts[2],
                ngaySinh = DateTime.Parse(parts[3]),
                diaChi = parts[4],
                lop = parts[5]
            };
        }
    }
}
