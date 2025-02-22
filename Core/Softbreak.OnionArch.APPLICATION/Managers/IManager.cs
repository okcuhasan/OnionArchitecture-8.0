using Softbreak.OnionArch.APPLICATION.Dtos;
using Softbreak.OnionArch.DOMAIN.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.APPLICATION.Managers
{
    public interface IManager<D,T> where D : class, IEntity where T : class, IDto
    {
         /*
         * D -> ENTITY 
         * T -> DTO
         */

        IQueryable<T> GetAll();
        IQueryable<T> GetActives();
        IQueryable<T> GetModifieds();
        IQueryable<T> GetPassives();

        string Add(T item);
        Task<string> AddAsync(T item);
        string AddRange(List<T> items);
        Task<string> AddRangeAsync(List<T> items);
        string Update(T item);
        Task<string> UpdateAsync(T item);
        string UpdateRange(List<T> items);
        Task<string> UpdateRangeAsync(List<T> items);
        string Delete(T item);
        Task<string> DeleteAsync(T item);
        string DeleteRange(List<T> items);
        Task<string> DeleteRangeAsync(List<T> items);
        string Destroy(T item);
        string DestroyRange(List<T> items);
        Task<string> DestroyAsync(T item);
        Task<string> DestroyRangeAsync(List<T> items);

        IQueryable<T> Where(Expression<Func<D, bool>> exp);
        bool Any(Expression<Func<D, bool>> exp);
        Task<bool> AnyAsync(Expression<Func<D, bool>> exp);
        T FirstOrDefault(Expression<Func<D, bool>> exp);
        Task<T> FirstOrDefaultAsync(Expression<Func<D, bool>> exp);
        IQueryable<X> Select<X>(Expression<Func<D, X>> exp);

        T Find(int id);
        Task<T> FindAsync(int id);
    }
}
