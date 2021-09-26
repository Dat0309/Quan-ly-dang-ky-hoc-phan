using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDangKyHocPhan.Model
{
    public class QLHP
    {
        Context context;
        public delegate int SoSanh(object sv1, object sv2);
        public List<HocPhan> dshp;

        public QLHP()
        {
        }

        public QLHP(Context context)
        {
            this.context = context;
            this.dshp = context.GetHP();
        }

        public void Them(HocPhan hp)
        {
            dshp.Add(hp);
        }
        public HocPhan this[int index]
        {
            get { return dshp[index]; }
            set { dshp[index] = value; }
        }

        public HocPhan Tim(object obj1, SoSanh ss)
        {
            HocPhan hp = null;
            foreach (HocPhan item in dshp)
            {
                if (ss(obj1, item) == 0)
                {
                    hp = item;
                    break;
                }
            }
            return hp;
        }

        public void Xoa(object obj, SoSanh ss)
        {
            int i = dshp.Count - 1;
            for (; i > 0; i--)
            {
                if (ss(obj, this[i]) == 0)
                    dshp.RemoveAt(i);
            }
        }
    }
}
