using Project.Scripts.Game.Areas.Messages.Model;
using Project.Scripts.Game.Areas.Users.Model;

namespace Project.Scripts.Game.Base.Model
{
    public interface IGameModel
    {
        IUsersModel Users { get; }
        IMessagesModel Messages { get; }
    }
}