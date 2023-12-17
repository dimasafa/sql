using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace dbTest.Models
{
//    USE newTestDb
//go

//CREATE SCHEMA FirstSchema
//Go

//CREATE TABLE FirstSchema.Computer(
//    ComputerId INT IDENTITY(1,1) PRIMARY KEY,
//    Nummer INT,
//	CPU VARCHAR(50),
//	VideoCard VARCHAR(50),
//	Price DECIMAL(18,4)
//);


    public class Computer
    {
        public int ComputerId {  get; set; } 
        public int Nummer { get; set; }
        public string CPU { get; set; }
        public string VideoCard { get; set; }
        public decimal Price { get; set; }

        public Computer()
        {
            if (CPU == null)
            {
                CPU = "";
            }
            if (VideoCard == null)
            {
                VideoCard = "";
            }
        }
        //public Computer (int num, string cPU, string videoCard, double prise)
        //{
        //    Nummer = num;
        //    CPU = cPU;
        //    VideoCard = videoCard;
        //    Price = prise;
        //}


    }
}
