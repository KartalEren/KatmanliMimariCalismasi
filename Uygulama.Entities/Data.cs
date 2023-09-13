using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Core.BaseEntities;
using Uygulama.Core.Enums;

namespace Uygulama.Entities
{
    public class Data:BaseEntity
    {
        public string ProductName { get; set; }
        public double Calori { get; set; }
        public DateTime DateTime { get; set; }
        public Meal Meal { get; set; }
        public virtual User User { get; set; }
        public int? UserId { get; set; }
        public string UserEmail { get; set; }
        public virtual Product Product { get; set; }
        public int? ProductId { get; set; }

    }
}
