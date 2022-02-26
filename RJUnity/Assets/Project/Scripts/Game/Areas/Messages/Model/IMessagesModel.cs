using System;
using System.Collections.Generic;

namespace Project.Scripts.Game.Areas.Messages.Model
{
    public interface IMessagesModel
    {
        event Action<IMessageModel> OwnerSent;
        event Action<IMessageModel> OtherSent;
        event Action<IMessageModel> Removed;
        event Action<bool> SettingDisplayed;
        
        IEnumerable<IMessageModel> Messages { get; }

        void Send(string text);
        void DisplaySetting(bool isDisplay);
    }
}