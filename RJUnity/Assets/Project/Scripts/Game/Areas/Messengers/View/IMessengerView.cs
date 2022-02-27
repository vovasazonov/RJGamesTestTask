using Project.Scripts.Game.Areas.Messages.View;

namespace Project.Scripts.Game.Areas.Messengers.View
{
    public interface IMessengerView
    {
        IMessageView CreateOwner();
        IMessageView CreateOther();
    }
}