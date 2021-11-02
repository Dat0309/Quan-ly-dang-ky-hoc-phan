using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDangKyHocPhan.Model
{
    public class QLSV
    {
        private static QLSV _singleObject;
        Context context;
        public delegate int SoSanh(object sv1, object sv2);
        public List<SinhVien> dssv;

        private QLSV()
        {

        }

        private QLSV(Context context)
        {
            this.context = context;
            this.dssv = context.GetSV();
        }

        public static QLSV gettInstance(Context context)
        {
            if (_singleObject == null)
            {
                _singleObject = new QLSV(context);
            }
            return _singleObject;
        }

        public void Them(SinhVien sv)
        {
            dssv.Add(sv);
        }
        public SinhVien this[int index]
        {
            get { return dssv[index]; }
            set { dssv[index] = value; }
        }

        public SinhVien Tim(object obj1, SoSanh ss)
        {
            SinhVien sv = null;
            foreach (SinhVien item in dssv)
            {
                if(ss(obj1, item) == 0)
                {
                    sv = item;
                    break;
                }
            }
            return sv;
        }

        public void Xoa(object obj, SoSanh ss)
        {
            int i = dssv.Count - 1;
            for (; i > 0; i--)
            {
                if (ss(obj, this[i]) == 0)
                    dssv.RemoveAt(i);
            }
        }

    }
}
