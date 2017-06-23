using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses;

namespace DAL
{
    public class Context:DbContext,IUnitOfWork
    {
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }


        public Context():base("DefaultConnection")
        {
            
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Factor> Factor { get; set; }
        public DbSet<FactorDetail> FactorDetail { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Factor>().HasOptional(x => x.FactorDetail)
            //    .WithRequired(x=>x.Factor);
            //modelBuilder.Entity<FactorDetail>().HasRequired(x => x.Factor);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
