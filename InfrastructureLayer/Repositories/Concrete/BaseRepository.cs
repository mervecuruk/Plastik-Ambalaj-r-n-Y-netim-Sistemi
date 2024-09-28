﻿using DomainLayer.Entities.Abstract;
using DomainLayer.Repositories.Abstract;
using InfrastructureLayer.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Concrete
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IEntity
    {
        protected readonly AppDbContext _context;
        protected DbSet<TEntity> _dbSet;

        public BaseRepository()
        {
            _context = new AppDbContext();
            _dbSet = _context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await FindAsync(id);
            if (entity != null)
            {
                entity.DeleteDate = DateTime.Now;
                entity.IsActive = false;
                _dbSet.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<TEntity> FindAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<bool> GetActiveAsync(int id)
        {
            TEntity entity = await FindAsync(id);
            entity.IsActive=true;
            await UpdateAsync(entity);
            return true;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.Where(x => x.IsActive == true).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllForAdminAsync()
        {
            return await _dbSet.Where(x => x.IsActive == false).ToListAsync();
        }

        public IQueryable<TEntity> GetAllInclude()
        {
            return _dbSet.Where(x => x.IsActive == true);
        }

        //public IEnumerable<TEntity> Search(string keyword)
        //{
        //    return _dbSet.Where(x => x.IsActive == true);
        //}

        public async Task UpdateAsync(TEntity entity)
        {
            _dbSet.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
