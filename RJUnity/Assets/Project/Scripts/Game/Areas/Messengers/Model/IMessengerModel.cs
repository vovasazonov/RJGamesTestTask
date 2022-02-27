using System;
using System.Collections.Generic;
using Project.Scripts.Game.Areas.Messages.Model;

namespace Project.Scripts.Game.Areas.Messengers.Model
{
    public interface IMessengerModel
    {
        event Action<IMessageModel> OwnerSent;
        event Action<IMessageModel> OtherSent;
        event Action<IMessageModel> MessageRemoved;
        event Action<bool> SettingDisplayed;
        
        IEnumerable<IMessageModel> Messages { get; }

        void Send(string text);
        void DisplaySetting(bool isDisplay);
    }
}