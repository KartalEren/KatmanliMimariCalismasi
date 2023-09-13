using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.DAL.Abstract;
using Uygulama.DAL.Base.EntityFramework;
using Uygulama.DAL.Concrete.Context;
using Uygulama.Entities;

namespace Uygulama.DAL.Concrete.Repositories
{  /// <summary>
   /// ProductRepo'yu oluşturmak için Base klasörü içindeki BaseRepository class'ından ve IProductRepo'dan kalıtım verdik.
   /// </summary>
   /// <param name="context"></param>
    public class ProductRepo : BaseRepository<Product, VeganFitDbContext>, IProductRepo
    {
        public ProductRepo(VeganFitDbContext context) : base(context)
        {

        }
    }
}
