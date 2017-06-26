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

        public void RemoveById(int id)
        {
            var f = _factors.FirstOrDefault(x => x.Id == id);
            _factors.Remove(f);
        }

        public double GetTotalPrice()
        {
            return _factors.Select(x=>new { x.TotalPrice}).Sum(x => x.TotalPrice);
        }

        public double GetTotalPriceWithTax()
        {
            return _factors.Select(x => new { x.TotalPriceWithTax }).Sum(x => x.TotalPriceWithTax);
        }

        public Factor GetById(int id)
        {
            return _factors.FirstOrDefault(x => x.Id == id);
        }

        public List<FactorDetail> GetDetailsById(int id)
        {
            return _factors.Include(x=>x.FactorDetails).FirstOrDefault(x => x.Id == id).FactorDetails.ToList();
        }

        public List<Factor> GetFactors()
        {
            return _factors.Include(x=>x.FactorDetails).ToList();
        }

        public List<Factor> FilterByDate(DateTime start, DateTime end)
        {
            return _factors.Where(x => x.Date.Day >= start.Day && x.Date.Year >= start.Year && start.Date.Month >= start.Month && x.Date.Day <= end.Day && x.Date.Year <= end.Year && start.Date.Month <= end.Month).ToList();
        }
        public List<Factor> GetFactorsByDate(DateTime d)
        {
            //PersianCalendar p = new PersianCalendar();
            //p.GetDayOfMonth(d);
            return _factors.Where(x=>  x.Date.Day == d.Day && x.Date.Year == d.Year && x.Date.Month == d.Month).ToList();
        }
    }
}
