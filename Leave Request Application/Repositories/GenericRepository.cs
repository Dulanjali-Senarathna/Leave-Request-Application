﻿using Leave_Request_Application.Contracts;
using Leave_Request_Application.Data;
using Microsoft.EntityFrameworkCore;

namespace Leave_Request_Application.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);//find the dbset type and fins the id
            if (entity != null)
            {
                context.Set<T>().Remove(entity);//find the dbset type and remove the specific found item
            }

            await context.SaveChangesAsync();
        }

        //check if the item is exists or not
        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;

        }

        //get all items
        public async Task<List<T>> GetAllAsync()
        {
           return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
