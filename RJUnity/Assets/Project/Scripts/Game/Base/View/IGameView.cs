using Project.Scripts.Game.Areas.Messengers.View;

namespace Project.Scripts.Game.Base.View
{
    public interface IGameView
    {
        IMessengerView Messenger { get; }
    }
}