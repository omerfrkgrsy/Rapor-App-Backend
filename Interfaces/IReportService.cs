using Rapor_App.Models;
using System.Collections.Generic;
namespace Rapor_App.Interfaces
{
    public interface IReportService
    {
        List<dynamic> GetReports();
    }
}