using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Core.IBaseRepository;
using Uygulama.Entities;

namespace Uygulama.DAL.Abstract
{
    /// <summary>
    /// Data entity'sinin metotlarını oluşturmak için Core katmanında generic olarak oluşturulan IBaseRepository interface'inden kalıtım alındı.
    /// </summary>
    public interface IDataRepo : IBaseRepository<Data>
    {
    }
}
