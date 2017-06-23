using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DomainClasses;

namespace Services
{
    public class FactorService
    {
        private readonly IDbSet<Factor> _factors;

        public FactorService(IUnitOfWork uow)
        {
            _factors = uow.Set<Factor>();
        }

        public void Add(Factor f)
        {
            _factors.Add(f);
        }
        public void Remove(Factor f)
        {
            _factors.Remove(f);
        }

        public List<Factor> GetFactors()
        {
            return _factors.ToList();
        }
        public List<Factor> GetFactorsByDate(DateTime d)
        {
            //PersianCalendar p = new PersianCalendar();
            //p.GetDayOfMonth(d);
            return _factors.Where(x=>x.Date.Equals(d)).ToList();
        }
    }
}
