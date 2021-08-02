using DAL.SQL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.DTOs;
using Transport.Interfaces;

namespace DAL.SQL.Repositories
{
    public abstract class BaseRepository<Entity> : IBaseRepository where Entity : class, IBaseEntity
    {
        protected DbSet<Entity> dbSet;

        public BaseRepository(Context context)
        {
            this.dbSet = context.Set<Entity>();
        }

        public virtual bool Exists(Identifiable identifiable) => this.dbSet.Any(e => e.Id == identifiable.Id);
        public virtual bool Exists(int id) => this.dbSet.Any(e => e.Id == id);

        public virtual void Delete(Identifiable identifiable) => this.dbSet.Remove(this.dbSet.First(e => identifiable.Id == e.Id));
        public virtual void Delete(int id) => this.dbSet.Remove(this.dbSet.First(e => id == e.Id));
        public virtual void Delete(IEnumerable<Identifiable> identifiables) => this.dbSet.RemoveRange(this.dbSet.Where(e => identifiables.Any(identifiable => identifiable.Id == e.Id)));
        public virtual void Delete(IEnumerable<int> ids) => this.dbSet.RemoveRange(this.dbSet.Where(e => ids.Contains(e.Id)));
    }
}
