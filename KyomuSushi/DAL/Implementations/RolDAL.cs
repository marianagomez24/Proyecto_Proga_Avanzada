using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class RolDAL : DALGenericoImpl<Rol>, IRolDAL
    {
        public KyomuDbContext _context;

        public RolDAL(KyomuDbContext context) : base(context)
        {
            _context = context;

        }
    }
}
