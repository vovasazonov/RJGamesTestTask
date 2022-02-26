using System;
using System.Collections.Generic;
using System.Linq;
using Project.Scripts.Game.Areas.Users.Model;

namespace Project.Scripts.Game.Areas.Messages.Model
{
    public class MessagesModel : IMessagesModel
    {
        public event Action<IMessageModel> OwnerSent;
        public event Action<IMessageModel> OtherSent;
        public event Action<IMessageModel> Removed;
        public event Action<bool> SettingDisplayed;

        private readonly IUsersModel _users;
        private readonly HashSet<IMessageModel> _messages = new();

        public IEnumerable<IMessageModel> Messages => _messages;

        public MessagesModel(IUsersModel users)
        {
            _users = users;
        }

        public void Send(string text)
        {
            var user = GetRandomUser();
            var message = new MessageModel(user, DateTime.Now, text);
            _messages.Add(message);
            AddMessageListeners(message);

            if (message.User.Id == _users.OwnerUser)
            {
                CallOwnerSent(message);
            }
            else
            {
                CallOtherSent(message);
            }
        }

        public void DisplaySetting(bool isDisplay)
        {
            foreach (var message in _messages)
            {
                if (message.User.Id == _users.OwnerUser)
                {
                    message.DisplaySetting(isDisplay);
                }
            }
            
            CallSettingDisplayed(isDisplay);
        }

        private IUserModel GetRandomUser()
        {
            return _users.Users.Values.ElementAtOrDefault(new System.Random().Next(0, _users.Users.Count));
        }

        private void AddMessageListeners(IMessageModel model)
        {
            model.Removed += OnMessageRemoved;
        }

        private void RemoveMessageListeners(IMessageModel model)
        {
            model.Removed -= OnMessageRemoved;
        }

        private void OnMessageRemoved(IMessageModel model)
        {
            RemoveMessageListeners(model);
            _messages.Remove(model);
            CallRemoved(model);
        }

        private void CallOwnerSent(IMessageModel model)
        {
            OwnerSent?.Invoke(model);
        }
        
        private void CallOtherSent(IMessageModel model)
        {
            OtherSent?.Invoke(model);
        }

        private void CallRemoved(IMessageModel model)
        {
            Removed?.Invoke(model);
        }

        private void CallSettingDisplayed(bool isDisplay)
        {
            SettingDisplayed?.Invoke(isDisplay);
        }
    }
}