using Rapor_App.Models;
using System.Collections.Generic;
using System;
namespace Rapor_App.Models
{
    public class ReportViewModel
    {
        public List<ReportModel> reports {get;set;}

        public List<String> Columns {get;set;}
    }
}