using Project.Scripts.Game.Areas.Messages.Model;
using Project.Scripts.Game.Areas.Users.Model;
using Project.Scripts.Game.Base.Config;

namespace Project.Scripts.Game.Base.Model
{
    public class GameModel : IGameModel
    {
        public IUsersModel Users { get; }
        public IMessagesModel Messages { get; }

        public GameModel(IGameConfig config)
        {
            Users = new UsersModel(config.Users);
            Messages = new MessagesModel(Users);
        }
    }
}