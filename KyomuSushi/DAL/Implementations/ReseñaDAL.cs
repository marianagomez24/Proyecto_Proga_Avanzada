using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class ReseñaDAL : DALGenericoImpl<Reseña>, IReseñaDAL
    {
        public KyomuDbContext _context;

        public ReseñaDAL(KyomuDbContext context) : base(context)
        {
            _context = context;

        }

        public List<Reseña> GetAllReseñas()
        {
            throw new NotImplementedException();
        }
    }
}
