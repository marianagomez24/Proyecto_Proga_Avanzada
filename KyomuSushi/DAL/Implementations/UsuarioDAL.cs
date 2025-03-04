using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class UsuarioDAL : DALGenericoImpl<Usuario>, IUsuarioDAL
    {
        public KyomudbContext _context;

        public UsuarioDAL(KyomudbContext context) : base(context)
        {
            _context = context;

        }

        public List<Usuario> GetAllUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
