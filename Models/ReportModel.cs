using Rapor_App.Models;
using System.Collections.Generic;
using System;
namespace Rapor_App.Models
{
    public class ReportModel
    {
        public int WorkOrderCode {get;set;}
        public int TotalTime {get;set;}
        public List<ReportDetail> PostureList {get;set;}

        //public String[] Columns {get;set;}
    }
}