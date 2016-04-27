using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace PetaPoco
{
    public class SalesPeople
    {
        public int Id { get; set; }
        public string Name { set; get; }


        public SalesPeople(string name)
        {
            this.Name = name;
        }

  
    }
}

