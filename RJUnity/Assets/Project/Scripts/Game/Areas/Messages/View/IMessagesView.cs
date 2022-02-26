namespace Project.Scripts.Game.Areas.Messages.View
{
    public interface IMessagesView
    {
        IMessageView CreateOwner();
        IMessageView CreateOther();
    }
}