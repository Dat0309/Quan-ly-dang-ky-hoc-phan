﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyHocPhan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Data.IDataSource dataSource = new Data.SVDataSource("Data\\DSSV.txt");
            Data.IDataSourceHP dataSourceHP = new Data.HPDataSource("Data\\DSHP.txt");
            Context context = new Context(dataSource,dataSourceHP);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);           
            Application.Run(new Form1(context));
        }
    }
}
