using Softbreak.OnionArch.CONTRACT.Repositories;
using Softbreak.OnionArch.DOMAIN.Entities.Concretes;
using Softbreak.OnionArch.Persistence.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.Persistence.Repositories
{
    public class AppUserRoleRepository : BaseRepository<AppUserRole>, IAppUserRoleRepository
    {
        private readonly ApplicationDbContext _context;
        public AppUserRoleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
