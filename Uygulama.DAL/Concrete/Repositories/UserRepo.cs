using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Core.BaseEntities;
using Uygulama.DAL.Abstract;
using Uygulama.DAL.Base.EntityFramework;
using Uygulama.DAL.Concrete.Context;
using Uygulama.DAL.Concrete.Context.EntityConfigurations;
using Uygulama.Entities;

namespace Uygulama.DAL.Concrete.Repositories
{   /// <summary>
    /// UserRepo'yu oluşturmak için Base klasörü içindeki BaseRepository class'ından ve IUserRepo'dan kalıtım verdik.
    /// </summary>
    /// <param name="context"></param>
    public class UserRepo : BaseRepository<User, VeganFitDbContext>, IUserRepo
    {
        public UserRepo(VeganFitDbContext context) : base(context)
        {

        }
    }
}
