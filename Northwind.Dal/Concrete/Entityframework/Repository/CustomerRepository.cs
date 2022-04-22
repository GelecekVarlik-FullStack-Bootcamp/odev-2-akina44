using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    class CustomerRepository : GenericRepository<Customer>, ICustomerRepository

    {
     //context hem genericRepository için hemde burası için çalışır tek defa türer.
     //base kalıtım alınan sınıfa argüman göndermek için kullanılır
        public CustomerRepository(DbContext context) : base(context)
        {

        }
        //this() aynı sınıfta constract arası veri alışverişi için kullanılır
        public IQueryable<Customer> GetTotalReport()
        {
            return dbset.AsQueryable<Customer>();
        }
    }
}
