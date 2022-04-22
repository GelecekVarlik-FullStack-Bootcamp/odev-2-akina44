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
     class AlphabeticalListOfProductRepository : GenericRepository<AlphabeticalListOfProduct>, IAlphabeticalListOfProductRepository
    {
                  //context hem genericRepository için hemde burası için çalışır tek defa türer.
                  //base kalıtım alınan sınıfa argüman göndermek için kullanılır
        public AlphabeticalListOfProductRepository(DbContext context) :base (context)
        {

        }
    }
}
