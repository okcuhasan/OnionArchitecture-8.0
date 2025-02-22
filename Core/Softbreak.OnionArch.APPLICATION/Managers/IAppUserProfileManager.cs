using Softbreak.OnionArch.APPLICATION.Dtos.Profiles;
using Softbreak.OnionArch.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.APPLICATION.Managers
{
    public interface IAppUserProfileManager : IManager<AppUserProfile, ProfileDto>
    {
    }
}
