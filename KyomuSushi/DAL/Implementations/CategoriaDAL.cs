using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class CategoriaDAL : DALGenericoImpl<Categorium>, ICategoriaDAL
    {
        public KyomuDbContext _context;

        public CategoriaDAL(KyomuDbContext context) : base(context)
        {
            _context = context;

        }

        public List<Categorium> GetAllCategorias()
        {
            return _context.Categoria
                .Select(e => new Categorium
                {
                    IdCategoria = e.IdCategoria,
                    NombreCategoria = e.NombreCategoria,
                    Descripcion = e.Descripcion

                })
                .ToList();
        }

        public bool Add(Categorium entity)
        {
            try
            {
                _context.Categoria.Add(new Categorium
                {
                    IdCategoria = entity.IdCategoria,
                    NombreCategoria = entity.NombreCategoria,
                    Descripcion = entity.Descripcion
                });
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }
    }
}

