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
    public class AppRoleRepository : BaseRepository<AppRole>, IAppRoleRepository
    {
        private readonly ApplicationDbContext _context;
        public AppRoleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
