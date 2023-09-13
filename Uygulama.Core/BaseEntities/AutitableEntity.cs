using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Core.BaseEntities
{
    public abstract class AutitableEntity:BaseEntity
    {
        public DateTime? DeletedDate { get; set; }
        //tam silme işlemi için
    }
}
