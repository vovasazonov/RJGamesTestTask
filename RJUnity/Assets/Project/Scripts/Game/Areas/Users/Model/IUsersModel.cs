using System.Collections.Generic;

namespace Project.Scripts.Game.Areas.Users.Model
{
    public interface IUsersModel
    {
        IReadOnlyDictionary<int, IUserModel> Users { get; }
        int OwnerUser { get; }
    }
}