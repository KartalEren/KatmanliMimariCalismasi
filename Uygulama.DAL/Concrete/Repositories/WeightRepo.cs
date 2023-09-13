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
{    /// <summary>
     /// WeightRepo'yu oluşturmak için Base klasörü içindeki BaseRepository class'ından ve IWeightRepo'dan kalıtım verdik.
     /// </summary>
    public class WeightRepo : BaseRepository<Weight, VeganFitDbContext>, IWeightRepo
    {
        public WeightRepo(VeganFitDbContext context) : base(context)
        {

        }
    }
}
