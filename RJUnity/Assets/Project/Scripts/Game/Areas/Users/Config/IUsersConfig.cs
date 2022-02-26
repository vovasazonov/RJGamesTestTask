using System.Collections.Generic;

namespace Project.Scripts.Game.Areas.Users.Config
{
    public interface IUsersConfig
    {
        IEnumerable<IUserConfig> Users { get; }
        int OwnerUserId { get; }
    }
}