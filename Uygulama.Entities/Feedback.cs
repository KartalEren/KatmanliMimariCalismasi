using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Core.BaseEntities;

namespace Uygulama.Entities
{
    public class Feedback : BaseEntity
    {
        public string? Message { get; set; }
        public string? UserName { get; set; }
        public User User { get; set; }
        public int? UserId { get; set; }

    }
}
