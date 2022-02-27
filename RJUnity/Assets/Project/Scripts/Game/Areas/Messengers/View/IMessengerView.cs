using System;
using Project.Scripts.Core.View;
using Project.Scripts.Game.Areas.Messages.View;

namespace Project.Scripts.Game.Areas.Messengers.View
{
    public interface IMessengerView : IDisposable
    {
        event Action SendClicked;
        event Action RemoveClicked;
        event Action ApproveClicked;
        
        string InputText { get; set; }
        
        IViewCreator<IMessageView> GetOwnerMessageCreator();
        IViewCreator<IMessageView> GetOtherMessageCreator();
        void DisplaySettings(bool isDisplay);
    }
}