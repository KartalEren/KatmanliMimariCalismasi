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
{   /// <summary>
    /// FeedbackRepo'yu oluşturmak için Base klasörü içindeki BaseRepository class'ından ve IFeedbackRepo'dan kalıtım verdik.
    /// </summary>
    public class FeedBackRepo : BaseRepository<Feedback, VeganFitDbContext>, IFeedBackRepo
    {
        public FeedBackRepo(VeganFitDbContext context) : base(context)
        {

        }
    }
}
