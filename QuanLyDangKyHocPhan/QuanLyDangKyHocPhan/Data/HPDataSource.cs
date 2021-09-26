using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDangKyHocPhan.Model;
using System.IO;

namespace QuanLyDangKyHocPhan.Data
{
    public class HPDataSource : IDataSourceHP
    {
        private string fileName;

        public HPDataSource(string fileName)
        {
            this.fileName = fileName;
        }

        public List<HocPhan> GetHP()
        {
            List<HocPhan> hp = new List<HocPhan>();
            if (File.Exists(fileName))
            {
                using (var reader = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read)))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        var hocphan = ParseHP(line);
                        hp.Add(hocphan);
                    }
                }
            }
            return hp;
        }

        public void Save(List<HocPhan> hp)
        {
            throw new NotImplementedException();
        }

        private HocPhan ParseHP(string line)
        {
            var parts = line.Split('*');
            return new HocPhan()
            {
                mahp = parts[0],
                tenhp = parts[1],
                tongTC = int.Parse(parts[2]),
                tclt = int.Parse(parts[3]),
                tcth = int.Parse(parts[4]),
                loaiTC = parts[5]
            };
        }
    }
}
