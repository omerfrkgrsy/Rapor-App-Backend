using System;
namespace Rapor_App.Models
{
    public class WorkOrder
    {
        public DateTime StartDate{get;set;}

        public DateTime FinishDate { get; set; }

        public int WorkOrderCode { get; set; }
    }
}