using Softbreak.OnionArch.DOMAIN.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.CONTRACT.Repositories
{
    public interface IRepository<T> where T : class, IEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetActives();
        IQueryable<T> GetModifieds();
        IQueryable<T> GetPassives();

        void Add(T item);
        Task AddAsync(T item);
        void AddRange(List<T> items);
        Task AddRangeAsync(List<T> items);
        void Update(T item);
        Task UpdateAsync(T item);
        void UpdateRange(List<T> items);
        Task UpdateRangeAsync(List<T> items);
        void Delete(T item);
        Task DeleteAsync(T item);
        void DeleteRange(List<T> items);
        Task DeleteRangeAsync(List<T> items);
        void Destroy(T item);
        void DestroyRange(List<T> items);
        Task DestroyAsync(T item);
        Task DestroyRangeAsync(List<T> items);

        IQueryable<T> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        Task<bool> AnyAsync(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp);
        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);

        T Find(int id);
        Task<T> FindAsync(int id);
    }
}
