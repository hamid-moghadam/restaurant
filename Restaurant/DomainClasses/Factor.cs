using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
    public class Factor
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double TotalPrice { get; set; }
        public double TotalPriceWithTax { get; set; }
        public ICollection<FactorDetail> FactorDetails { get; set; }





        public override string ToString()
        {
            return string.Format("{0}        {1}        {2}", Id, Date.ToShortDateString(), TotalPriceWithTax);
        }
    }
}
