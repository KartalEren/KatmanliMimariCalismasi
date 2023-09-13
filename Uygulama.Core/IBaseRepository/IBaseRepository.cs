using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Core.BaseEntities;

namespace Uygulama.Core.IBaseRepository
{   // Kullanılacak metotları tüm entity'lere göre ayrı ayrı yazmamak için generic metot yöntemiyle interface'leri oluşturuldu.
    public interface IBaseRepository<TEntity>where TEntity : BaseEntity
    {
        // Database'e yeni veri ekleyen ve bu veriyi döndüren metot. (Yapılan işlemin doğrunu kontrol etmek için değer döndürüyoruz.)
        TEntity Create(TEntity entity);


        // Database'deki veriyi güncelleyen ve bu veriyi döndüren metot. (Yapılan işlemin doğrunu kontrol etmek için değer döndürüyoruz.)
        TEntity Update(TEntity entity);

        // Database'deki veri DeletedDate property'sine sahipse o veriyi database'den kaldıran sahip değilse verinin state property'sini Deleted olarak güncelleyen ve sonucu boolean olarak döndüren metot. (Yapılan işlemin doğrunu kontrol etmek için değer döndürüyoruz.)
        bool Delete(TEntity entity);


        // Database'de parametredeki şartı sağlayan verinin olup olmadığını kontrol eden ve sonucu boolean değer döndüren metot.
        bool Any(Expression<Func<TEntity, bool>> filter);


        // Database'de parametredeki şartı sağlayan tüm verilen listesini döndüren metot
        TEntity? GetFirstOrDefault(Expression<Func<TEntity, bool>> filter);


        // Database'de parametredeki şartı sağlayan tüm verilen listesini döndüren metot.
        ICollection<TEntity>? GetAll(Expression<Func<TEntity, bool>> filter = null);



        // Database'de parametredeki şartı sağlayan tüm verilen listesini döndüren metot.
        TResult? GetFilteredFirstOrDefault<TResult>(Expression<Func<TEntity, TResult>> select,
                                                  Expression<Func<TEntity, bool>> where,
                                                  Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>?
                                                  orderBy = null,
                                                  params Expression<Func<TEntity, object>>[] includes);


        // Database'de parametredeki şartı sağlayan tüm verilen listesini döndüren metot. (TResult => DTO / VM)
        ICollection<TResult>? GetFilteredList<TResult>(Expression<Func<TEntity, TResult>> select,
                                                               Expression<Func<TEntity, bool>> where,
                                                               Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>?
                                                               orderBy = null,
                                                               params Expression<Func<TEntity, object>>[] includes);












    }
}
