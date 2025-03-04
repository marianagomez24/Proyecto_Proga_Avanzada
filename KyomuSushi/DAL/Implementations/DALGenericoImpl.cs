using DAL.Interfaces;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class DALGenericoImpl<TEntity> : IDALGenerico<TEntity> where TEntity : class
    {

        private KyomudbContext _context;

        public DALGenericoImpl(KyomudbContext context)
        {
            
            _context = context;
        }

        public bool Add(TEntity entity)
        {
            try
            {
                _context.Add(entity);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public TEntity Get(int id)
        {

            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public bool Remove(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Attach(entity);
                _context.Set<TEntity>().Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
