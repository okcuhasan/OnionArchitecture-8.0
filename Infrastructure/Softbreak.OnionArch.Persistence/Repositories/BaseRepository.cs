using Microsoft.EntityFrameworkCore;
using Softbreak.OnionArch.CONTRACT.Repositories;
using Softbreak.OnionArch.DOMAIN.Entities.Abstracts;
using Softbreak.OnionArch.Persistence.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.Persistence.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(T item)
        {
            _context.Set<T>().Add(item);
            _context.SaveChanges();
        }

        public async Task AddAsync(T item)
        {
            await _context.Set<T>().AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public void AddRange(List<T> items)
        {
            _context.Set<T>().AddRange(items);
            _context.SaveChanges();
        }

        public async Task AddRangeAsync(List<T> items)
        {
            await _context.Set<T>().AddRangeAsync(items);
            await _context.SaveChangesAsync();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Any(exp);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> exp)
        {
            return await _context.Set<T>().AnyAsync(exp);
        }

        public void Delete(T item)
        {
            item.Status = DOMAIN.Enums.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            _context.SaveChanges();
        }

        public async Task DeleteAsync(T item)
        {
            item.Status = DOMAIN.Enums.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            await _context.SaveChangesAsync();
        }

        public void DeleteRange(List<T> items)
        {
            foreach(T item in items)
            {
                Delete(item);
            }
        }

        public async Task DeleteRangeAsync(List<T> items)
        {
            foreach(T item in items)
            {
                await DeleteAsync(item);
            }
        }

        public void Destroy(T item)
        {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }

        public async Task DestroyAsync(T item)
        {
            _context.Set<T>().Remove(item);
            await _context.SaveChangesAsync();
        }

        public void DestroyRange(List<T> items)
        {
            foreach(T item in items)
            {
                Destroy(item);
            }
        }

        public async Task DestroyRangeAsync(List<T> items)
        {
            foreach(T item in items)
            {
                await DestroyAsync(item);
            }
        }

        public T Find(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public async Task<T> FindAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().FirstOrDefault(exp);
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(exp);
        }

        public IQueryable<T> GetActives()
        {
            return _context.Set<T>().Where(x => x.Status != DOMAIN.Enums.DataStatus.Deleted);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }

        public IQueryable<T> GetModifieds()
        {
            return _context.Set<T>().Where(x => x.Status == DOMAIN.Enums.DataStatus.Updated);
        }

        public IQueryable<T> GetPassives()
        {
            return _context.Set<T>().Where(x => x.Status == DOMAIN.Enums.DataStatus.Deleted);
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            return _context.Set<T>().Select(exp);
        }

        public void Update(T item)
        {
            item.Status = DOMAIN.Enums.DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            T entity = Find(item.Id);
            _context.Entry(entity).CurrentValues.SetValues(item);
            _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T item)
        {
            item.Status = DOMAIN.Enums.DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            T entity = await FindAsync(item.Id);
            _context.Entry(entity).CurrentValues.SetValues(item);
            await _context.SaveChangesAsync();
        }

        public void UpdateRange(List<T> items)
        {
            foreach(T item in items)
            {
                Update(item);
            }
        }

        public async Task UpdateRangeAsync(List<T> items)
        {
            foreach(T item in items)
            {
                await UpdateAsync(item);
            }
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Where(exp);
        }
    }
}
