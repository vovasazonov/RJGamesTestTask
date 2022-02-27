using Project.Scripts.Core.View;
using Project.Scripts.Game.Areas.Messengers.View;

namespace Project.Scripts.Game.Base.View
{
    public interface IGameView
    {
        IViewCreator<IPrimitiveView> Camera { get; }
        IViewCreator<IPrimitiveView> EventSystem { get; }
        IViewCreator<IMessengerView> Messenger { get; }
    }
}