using Project.Scripts.Game.Areas.Users.Config;

namespace Project.Scripts.Game.Areas.Users.Model
{
    public class UserModel : IUserModel
    {
        private readonly IUserConfig _userConfig;

        public int Id => _userConfig.Id;

        public UserModel(IUserConfig userConfig)
        {
            _userConfig = userConfig;
        }
    }
}