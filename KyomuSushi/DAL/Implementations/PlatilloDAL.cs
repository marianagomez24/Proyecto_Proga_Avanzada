using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class PlatilloDAL : DALGenericoImpl<Platillo>, IPlatilloDAL
    {
        public KyomudbContext _context;

        public PlatilloDAL(KyomudbContext context) : base(context)
        {
            _context = context;

        }

        public List<Platillo> GetAllPlatillos()
        {
            throw new NotImplementedException();
        }
    }
}
