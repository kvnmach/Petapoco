using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetaPoco
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new PetaPoco.Database("dbstring");
     
        

            List<SalesPeople> salesperson = new List<SalesPeople>();
            salesperson.Add(new SalesPeople("Deacon"));
            salesperson.Add(new SalesPeople("Edan"));
            salesperson.Add(new SalesPeople("Yardley"));
            salesperson.Add(new SalesPeople("Farrah"));
            salesperson.Add(new SalesPeople("Jessamine"));
            salesperson.Add(new SalesPeople("Isabelle"));
            salesperson.Add(new SalesPeople("Judah"));

            foreach (var p in salesperson)
            {
                db.Insert("SalesPeople", "Id", p);
            }

            List<SalesMade> salesmade = new List<SalesMade>()
            {
                new SalesMade("Deacon", new DateTime(2015, 10, 15), 8852),
                new SalesMade("Edan", new DateTime(2015, 12, 07), 5255),
                new SalesMade("Deacon", new DateTime(2016, 02, 27), 5259),
                new SalesMade("Yardley", new DateTime(2015, 11, 23), 7244),
                new SalesMade("Farrah", new DateTime(2015, 12, 21), 8711),
                new SalesMade("Deacon", new DateTime(2015, 10, 02), 740),
                new SalesMade("Jessamine", new DateTime(2015, 04, 02), 9970),
                new SalesMade("Isabelle", new DateTime(2015, 12, 25), 6009),
                new SalesMade("Judah", new DateTime(2014, 07, 03), 9703)
            };

            foreach (var s in salesmade)
            {
                db.Insert("SalesMade", "Id",s);
            }

            
            Console.WriteLine("SalesPeople and there Information");
            foreach (var s in db.Query<SalesPeople>("select * from SalesPeople"))
            {
                Console.WriteLine($"Sales Person Name is {s.Name}");
            }
            Console.WriteLine("Salesmade");
            foreach (var s in db.Query<SalesMade>("select * from SalesMade"))
            {
                Console.WriteLine($"{s.Name} made a sale on {s.SalesDate.ToShortDateString()} and pretax amount is {s.PreTaxAmount}");
            }
            Console.WriteLine("Minimum Sales Scale");
            foreach (var smin in db.Query<SalesMade>("Select min(PreTaxAmount) SalesMade"))
            {
                Console.WriteLine(smin.PreTaxAmount);
            }
            Console.WriteLine("Maximum Sales Scale");
            foreach (var smax in db.Query<SalesMade>("Select max(PreTaxAmount) SalesMade"))
            {
                Console.WriteLine(smax.PreTaxAmount);
            }
            Console.WriteLine("Total Sales Report:");
            foreach (var d in db.Query<SalesMade>("select datediff(day, min(SalesDate), max(SalesDate) from SalesMade"))
            {
                Console.WriteLine(d);
            }


            Console.ReadLine();






        }
    }
}







