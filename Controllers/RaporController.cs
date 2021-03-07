using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rapor_App.Models;
using Rapor_App.DataAccess;
using Rapor_App.Interfaces;
namespace Rapor_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        
        private readonly IReportService _reportService;
        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }
        
        [HttpGet("GetReport")]
        public List<dynamic> Get2()
        {
            return _reportService.GetReports();
        }
    }
}
