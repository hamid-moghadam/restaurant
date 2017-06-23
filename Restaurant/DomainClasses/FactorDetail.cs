using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
    public class FactorDetail
    {
        
        public int Id { get; set; }
        public int Count { get; set; }
        public double TotalPrice { get; set; }
        public string Description { get; set; }
        [ForeignKey("Factor")]
        public int FactorId { get; set; }
        public Factor Factor { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
