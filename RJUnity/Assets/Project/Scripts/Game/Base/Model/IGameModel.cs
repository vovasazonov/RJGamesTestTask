using Project.Scripts.Game.Areas.Messengers.Model;
using Project.Scripts.Game.Areas.Users.Model;

namespace Project.Scripts.Game.Base.Model
{
    public interface IGameModel
    {
        IUsersModel Users { get; }
        IMessengerModel Messenger { get; }
    }
}