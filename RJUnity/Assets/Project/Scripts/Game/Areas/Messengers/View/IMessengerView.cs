using System;
using Project.Scripts.Game.Areas.Messages.View;

namespace Project.Scripts.Game.Areas.Messengers.View
{
    public interface IMessengerView
    {
        event Action SendClicked;
        event Action RemoveClicked;
        event Action ApproveClicked;
        
        string InputText { get; set; }
        
        IMessageView CreateOwner();
        IMessageView CreateOther();
        void DisplaySettings(bool isDisplay);
    }
}