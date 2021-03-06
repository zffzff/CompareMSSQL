﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;
using CompareMSSQL.Enum;

namespace CompareMSSQL.Entity
{
    class DBTableView : CompareSourceView
    {

        public DBTableView()
        {

        }

        public DBTableView(Table tb, bool isSource, DifferencesType dt, string connectStr = "", string compareConnectStr = "")
        {
            DBTable = tb;
            IsSourceDB = isSource;
            Differences = dt;
            ConnectString = connectStr;
            CompareConnectString = compareConnectStr;
        }

        /// <summary>
        /// 表
        /// </summary>
        public Table DBTable { get; set; }

    }
}
