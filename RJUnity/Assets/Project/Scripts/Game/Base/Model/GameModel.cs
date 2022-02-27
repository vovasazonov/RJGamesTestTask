using Project.Scripts.Game.Areas.Messengers.Model;
using Project.Scripts.Game.Areas.Users.Model;
using Project.Scripts.Game.Base.Config;

namespace Project.Scripts.Game.Base.Model
{
    public class GameModel : IGameModel
    {
        public IUsersModel Users { get; }
        public IMessengerModel Messenger { get; }

        public GameModel(IGameConfig config)
        {
            Users = new UsersModel(config.Users);
            Messenger = new MessengerModel(Users);
        }
    }
}