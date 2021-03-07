using Rapor_App.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace Rapor_App.DataAccess
{
    public class PostureRepo
    {
        public List<Posture> getData(){
            
            return new List<Posture>(){
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,1,10,00,00),
                    FinishDate=new DateTime(2017,01,1,10,10,00)
                },
                new Posture{
                    PostureReason="Arıza",
                    StartDate=new DateTime(2017,01,1,10,30,00),
                    FinishDate=new DateTime(2017,01,1,11,00,00)
                },
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,1,12,00,00),
                    FinishDate=new DateTime(2017,01,1,12,30,00)
                },
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,2,14,00,00),
                    FinishDate=new DateTime(2017,01,2,14,10,00)
                },
                new Posture{
                    PostureReason="Setup",
                    StartDate=new DateTime(2017,01,1,15,00,00),
                    FinishDate=new DateTime(2017,01,1,16,30,00)
                },
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,1,18,00,00),
                    FinishDate=new DateTime(2017,01,1,18,10,00)
                },
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,1,20,00,00),
                    FinishDate=new DateTime(2017,01,1,20,30,00)
                },
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,1,22,00,00),
                    FinishDate=new DateTime(2017,01,1,22,10,00)
                },
                new Posture{
                    PostureReason="Arge",
                    StartDate=new DateTime(2017,01,1,23,00,00),
                    FinishDate=new DateTime(2017,01,2,8,30,00)
                },
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,2,10,00,00),
                    FinishDate=new DateTime(2017,01,2,10,10,00)
                },
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,2,12,00,00),
                    FinishDate=new DateTime(2017,01,2,12,30,00)
                },
                new Posture{
                    PostureReason="Arıza",
                    StartDate=new DateTime(2017,01,2,13,00,00),
                    FinishDate=new DateTime(2017,01,2,13,45,00)
                },
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,1,14,00,00),
                    FinishDate=new DateTime(2017,01,1,14,10,00)
                },
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,2,18,00,00),
                    FinishDate=new DateTime(2017,01,2,18,10,00)
                },
                new Posture{
                    PostureReason="Arge",
                    StartDate=new DateTime(2017,01,2,20,00,00),
                    FinishDate=new DateTime(2017,01,3,02,10,00)
                },
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,3,04,00,00),
                    FinishDate=new DateTime(2017,01,3,04,30,00)
                },
                new Posture{
                    PostureReason="Setup",
                    StartDate=new DateTime(2017,01,3,06,00,00),
                    FinishDate=new DateTime(2017,01,3,9,30,00)
                },
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,3,10,00,00),
                    FinishDate=new DateTime(2017,01,3,10,10,00)
                },
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,3,12,00,00),
                    FinishDate=new DateTime(2017,01,3,12,30,00)
                },
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,3,14,00,00),
                    FinishDate=new DateTime(2017,01,3,14,10,00)
                },
                new Posture{
                    PostureReason="Arıza",
                    StartDate=new DateTime(2017,01,3,15,00,00),
                    FinishDate=new DateTime(2017,01,3,18,45,00)
                },
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,3,20,00,00),
                    FinishDate=new DateTime(2017,01,3,20,30,00)
                },
                new Posture{
                    PostureReason="Mola",
                    StartDate=new DateTime(2017,01,3,22,00,00),
                    FinishDate=new DateTime(2017,01,3,22,10,00)
                },
            };

        }
    }
}