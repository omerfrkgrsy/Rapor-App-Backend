using Rapor_App.Interfaces;
using Rapor_App.DataAccess;
using Rapor_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Rapor_App.Services
{
    public class ReportService:IReportService
    {
        public List<dynamic> GetReports(){
            WorkOrderRepo workOrder = new WorkOrderRepo();
            PostureRepo posture = new PostureRepo();
            List<PostureBusiness> postureBusinessList=new List<PostureBusiness>();
                workOrder.getData().ForEach(x=> {
                    posture.getData().ForEach(y=>{         
                        PostureBusiness postureBusiness=new PostureBusiness(); 
                        if((y.StartDate>x.StartDate && y.StartDate<x.FinishDate) || (y.FinishDate>x.StartDate && y.FinishDate<x.FinishDate)){
                            if(y.FinishDate>x.FinishDate){
                                y.FinishDate=x.FinishDate;
                            }else if(y.StartDate<x.StartDate){
                                y.StartDate=x.StartDate;
                            }
                            postureBusiness.WorkOrderCode=x.WorkOrderCode;
                            postureBusiness.Reason=y.PostureReason;
                            TimeSpan t=y.FinishDate-y.StartDate;
                            postureBusiness.Time=Convert.ToInt32(t.TotalMinutes);
                            postureBusinessList.Add(postureBusiness);
                        }else if((x.StartDate>y.StartDate && x.StartDate<y.FinishDate) || (x.FinishDate>y.StartDate && x.FinishDate<y.FinishDate)){
                            y.FinishDate=x.FinishDate;
                            postureBusiness.WorkOrderCode=x.WorkOrderCode;
                            y.StartDate=x.StartDate;
                            postureBusiness.Reason=y.PostureReason;
                            TimeSpan t=y.FinishDate-y.StartDate;
                            postureBusiness.Time=Convert.ToInt32(t.TotalMinutes);
                            postureBusinessList.Add(postureBusiness);
                        }
                    });
                   });
            List<String> model1=new List<String>();
            //model1.Add("İş Emri Kodu");       
            model1.AddRange(postureBusinessList.GroupBy(u=> new {u.Reason}).Select(u=> u.First().Reason).ToList());
            //model1.Add("Toplam");
            var model5=postureBusinessList.GroupBy(u=> new {u.Reason,u.WorkOrderCode}).Select(
            g => new PostureBusiness
            {
                Time = g.Sum(t=>t.Time),
                WorkOrderCode = g.First().WorkOrderCode,
                Reason = g.First().Reason 
            }).GroupBy(u=> new {u.WorkOrderCode}).ToList();
            dynamic MyDynamic = new System.Dynamic.ExpandoObject();
            MyDynamic.A = "A";
            MyDynamic.B = "B";
            MyDynamic.C = "C";
            var model=postureBusinessList.GroupBy(u=> new {u.Reason,u.WorkOrderCode}).Select(
            g => new PostureBusiness
            {
                Time = g.Sum(t=>t.Time),
                WorkOrderCode = g.First().WorkOrderCode,
                Reason = g.First().Reason 
            }).GroupBy(u=> new {u.WorkOrderCode}).Select(
            g => new ReportModel
            {
                TotalTime = g.Sum(t=>t.Time),
                WorkOrderCode = g.First().WorkOrderCode,
                PostureList = g.ToArray().Select(t=>new ReportDetail{ Reason=t.Reason,Time=t.Time }).ToList(),

            }).ToList();
            dynamic output = new List<dynamic>();
            foreach(ReportModel r in model){
                dynamic exo = new System.Dynamic.ExpandoObject();
                
                    ((IDictionary<String, Object>)exo).Add("İsYeriKodu", r.WorkOrderCode);
                    foreach (string field in model1)
                    {
                       var k=r.PostureList.Find(x=>x.Reason==field);
                        if(k!=null){
                            ((IDictionary<String, Object>)exo).Add(field,k.Time);
                        }else{
                            ((IDictionary<String, Object>)exo).Add(field,0);
                        }
                    }
                    ((IDictionary<String, Object>)exo).Add("Toplam", r.TotalTime);
                
                output.Add(exo);
            }
            return output;
        }
    }
}
                                                     