using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DomainClasses;

namespace Services
{
    public class FactorDetailService
    {
        private IDbSet<FactorDetail> _factorDetails;

        public FactorDetailService(IUnitOfWork uow)
        {
            _factorDetails = uow.Set<FactorDetail>();
        }

        public void Add(FactorDetail fd)
        {
            _factorDetails.Add(fd);
        }

        public void Remove(FactorDetail fd)
        {
            _factorDetails.Remove(fd);
        }

        public List<FactorDetail> GetFactorDetails()
        {
            return _factorDetails.ToList();
        }
    }
}
