using Softbreak.OnionArch.DOMAIN.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.DOMAIN.Entities.Concretes
{
    public class AppUserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
