using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teknoser_Log_Zipper.Models.Northwind;

namespace Teknoser_Log_Zipper
{
    public class NorthWindOperation
    {
        public void NorthwindHandler()
        {
            NorthwindContext context = new NorthwindContext();
         
            var data = context.Personellers.FirstOrDefault();

            data.Adi = "Taha";
            data.SoyAdi = "Stephan";
            data.Bolge = "Türkiye";
            data.Sehir = "İstanbul";
            context.Update(data);
            context.SaveChanges();

            Console.WriteLine(data);
        }
    }
}