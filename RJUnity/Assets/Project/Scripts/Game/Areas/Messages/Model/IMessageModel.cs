using System;
using Project.Scripts.Game.Areas.Users.Model;

namespace Project.Scripts.Game.Areas.Messages.Model
{
    public interface IMessageModel
    {
        event Action<bool> SettingDisplayed;
        event Action<IMessageModel> Removed;
        
        IUserModel User { get; }
        DateTime Time { get; }
        string Text { get; }

        void DisplaySetting(bool isDisplay);
        void Remove();
    }
}