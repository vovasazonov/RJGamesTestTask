using System;
using Project.Scripts.Game.Areas.Users.Model;

namespace Project.Scripts.Game.Areas.Messages.Model
{
    public class MessageModel : IMessageModel
    {
        public event Action<bool> SettingDisplayed;
        public event Action<IMessageModel> Removed;
        public event Action HighlightUpdated;

        private bool _isHighlight;
        
        public IUserModel User { get; }
        public DateTime Time { get; }
        public string Text { get; }

        public bool IsHighlight
        {
            get => _isHighlight;
            set
            {
                if (value != _isHighlight)
                {
                    _isHighlight = value;
                    CallHighlightUpdated();
                }   
            }
        }

        public MessageModel(IUserModel user, DateTime time, string text)
        {
            User = user;
            Time = time;
            Text = text;
        }

        public void DisplaySetting(bool isDisplay)
        {
            CallSettingDisplayed(isDisplay);
        }

        public void Remove()
        {
            CallRemoved();
        }

        private void CallRemoved()
        {
            Removed?.Invoke(this);
        }

        private void CallSettingDisplayed(bool isDisplayed)
        {
            SettingDisplayed?.Invoke(isDisplayed);
        }

        private void CallHighlightUpdated()
        {
            HighlightUpdated?.Invoke();
        }
    }
}