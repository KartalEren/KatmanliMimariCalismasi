using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Core.Enums;

namespace Uygulama.Core.BaseEntities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateBy { get; set; }
        public State State { get; set; }
        //state enum'daki Deleted=>gevşek silme(veri tabanından kaldırmıyor, sadece silindi olarak işaretleyip yapacağımız filtreye göre onu göstermiyor bize.)

    }
}
