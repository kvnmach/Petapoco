using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace PetaPoco
{
    public class SalesMade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime SalesDate { get; set; }
        public int PreTaxAmount { get; set; }

        public SalesMade(string name, DateTime salesDate, int pretax)
        {
            this.Name = name;
            this.SalesDate = salesDate;
            this.PreTaxAmount = pretax;
        }

       
    }

}
