using System.Collections.Generic;
using Project.Scripts.Game.Areas.Users.Config;

namespace Project.Scripts.Game.Areas.Users.Model
{
    public class UsersModel : IUsersModel
    {
        public IReadOnlyDictionary<int, IUserModel> Users { get; }

        public int OwnerUser { get; }

        public UsersModel(IUsersConfig config)
        {
            OwnerUser = config.OwnerUserId;
            Dictionary<int, IUserModel> users = new Dictionary<int, IUserModel>();

            foreach (var userConfig in config.Users)
            {
                var model = new UserModel(userConfig);
                users.Add(model.Id, model);
            }

            Users = users;
        }
    }
}