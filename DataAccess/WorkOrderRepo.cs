using Rapor_App.Models;
using System;
using System.Collections.Generic;
namespace Rapor_App.DataAccess
{
    public class WorkOrderRepo
    {
       public List<WorkOrder> getData(){
            
            return new List<WorkOrder>(){
                new WorkOrder{
                    WorkOrderCode=1001,
                    StartDate=new DateTime(2017,01,1,8,00,00),
                    FinishDate=new DateTime(2017,01,1,16,00,00)
                },
                new WorkOrder{
                    WorkOrderCode=1002,
                    StartDate=new DateTime(2017,01,1,16,00,00),
                    FinishDate=new DateTime(2017,01,2,00,00,00)
                },
                new WorkOrder{
                    WorkOrderCode=1003,
                    StartDate=new DateTime(2017,01,2,00,00,00),
                    FinishDate=new DateTime(2017,01,2,8,00,00)
                },
                new WorkOrder{
                    WorkOrderCode=1004,
                    StartDate=new DateTime(2017,01,2,8,00,00),
                    FinishDate=new DateTime(2017,01,2,16,00,00)
                },
                new WorkOrder{
                    WorkOrderCode=1005,
                    StartDate=new DateTime(2017,01,2,16,00,00),
                    FinishDate=new DateTime(2017,01,3,00,00,00)
                },
                new WorkOrder{
                    WorkOrderCode=1006,
                    StartDate=new DateTime(2017,01,3,00,00,00),
                    FinishDate=new DateTime(2017,01,3,08,00,00)
                },
                new WorkOrder{
                    WorkOrderCode=1007,
                    StartDate=new DateTime(2017,01,3,8,00,00),
                    FinishDate=new DateTime(2017,01,3,16,00,00)
                },
                new WorkOrder{
                    WorkOrderCode=1008,
                    StartDate=new DateTime(2017,01,3,16,00,00),
                    FinishDate=new DateTime(2017,01,4,00,00,00)
                },
                new WorkOrder{
                    WorkOrderCode=1009,
                    StartDate=new DateTime(2017,01,4,0,00,00),
                    FinishDate=new DateTime(2017,01,4,08,00,00)
                }
            };

        }
    }
}