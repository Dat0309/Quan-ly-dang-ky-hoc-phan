using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyHocPhan
{
    public partial class LoadingFrm : Form
    {

        public Action Worker { get; set; }
        public LoadingFrm(Action worker)
        {
            InitializeComponent();
            if (worker == null)
                throw new ArgumentNullException();
            this.Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(task =>
            {
                this.Close();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void LoadingFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
