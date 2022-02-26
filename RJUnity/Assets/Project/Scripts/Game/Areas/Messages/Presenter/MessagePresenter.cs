using System;
using Project.Scripts.Game.Areas.Messages.Model;
using Project.Scripts.Game.Areas.Messages.View;

namespace Project.Scripts.Game.Areas.Messages.Presenter
{
    public class MessagePresenter : IDisposable
    {
        private readonly IMessageModel _model;
        private readonly IMessageView _view;

        public MessagePresenter(IMessageModel model, IMessageView view)
        {
            _model = model;
            _view = view;
            
            AddListeners();
            RenderView();
        }

        private void RenderView()
        {
            throw new NotImplementedException();
        }

        private void AddListeners()
        {
            _model.Removed += OnRemoved;
            _model.SettingDisplayed += OnSettingDisplayed;
        }

        private void RemoveListeners()
        {
            _model.Removed -= OnRemoved;
            _model.SettingDisplayed -= OnSettingDisplayed;
        }

        private void OnSettingDisplayed(bool isDisplayed)
        {
            _view.DisplaySetting(isDisplayed);
        }

        private void OnRemoved(IMessageModel model)
        {
            _view.Remove();
        }

        public void Dispose()
        {
            RemoveListeners();
        }
    }
}