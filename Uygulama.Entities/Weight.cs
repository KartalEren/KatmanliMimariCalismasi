using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Core.BaseEntities;

namespace Uygulama.Entities
{
    public class Weight : BaseEntity
    {
        public double UserWeight { get; set; }
        public string UserName { get; set; }
        public DateTime RecordDate { get; set; }
        public virtual User User { get; set; }
        public int? UserId { get; set; }

    }
}
