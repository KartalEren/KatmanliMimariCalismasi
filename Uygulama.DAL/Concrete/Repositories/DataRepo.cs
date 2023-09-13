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
{/// <summary>
 /// DataRepo'yu oluşturmak için Base klasörü içindeki BaseRepository class'ından ve IDataRepo'dan kalıtım verdik.
 /// </summary>
    public class DataRepo : BaseRepository<Data, VeganFitDbContext>, IDataRepo
    {
        public DataRepo(VeganFitDbContext context) : base(context)
        {

        }
    }
}
