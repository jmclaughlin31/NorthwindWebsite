using Microsoft.PowerBI.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.PowerBI.Api.V1.Models;

/// <summary>
/// Summary description for ReportViewModel
/// </summary>
//public class ReportViewModel
//{
//    public ReportViewModel()
//    {
//        //
//        // TODO: Add constructor logic here
//        //
//    }
//}

namespace PowerBI.Models
{
    public class ReportViewModel
    {
        public Report Report { get; set; }

        public string AccessToken { get; set; }
    }
}