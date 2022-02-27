using System;
using Project.Scripts.Game.Areas.Messages.Model;
using Project.Scripts.Game.Areas.Messages.View;
using Project.Scripts.Game.Areas.Users.Config;

namespace Project.Scripts.Game.Areas.Messages.Presenter
{
    public class MessagePresenter : IDisposable
    {
        private readonly IMessageModel _model;
        private readonly IMessageView _view;
        private readonly IUserConfig _userConfig;

        public MessagePresenter(IMessageModel model, IMessageView view, IUserConfig userConfig)
        {
            _model = model;
            _view = view;
            _userConfig = userConfig;

            AddListeners();
            RenderView();
        }

        private void RenderView()
        {
            _view.Sprite = _userConfig.ProfileSprite;
            _view.NickName = _userConfig.NickName;
            _view.Time = _model.Time;
            _view.Text = _model.Text;
            _view.DisplaySetting(false);
        }

        private void AddListeners()
        {
            _model.SettingDisplayed += OnSettingDisplayed;
            _view.RemovedClicked += OnRemovedClicked;
        }

        private void RemoveListeners()
        {
            _model.SettingDisplayed -= OnSettingDisplayed;
            _view.RemovedClicked -= OnRemovedClicked;
        }

        private void OnRemovedClicked()
        {
            _model.Remove();
        }

        private void OnSettingDisplayed(bool isDisplayed)
        {
            _view.DisplaySetting(isDisplayed);
        }
        
        public void Dispose()
        {
            RemoveListeners();
            _view.Remove();
        }
    }
}