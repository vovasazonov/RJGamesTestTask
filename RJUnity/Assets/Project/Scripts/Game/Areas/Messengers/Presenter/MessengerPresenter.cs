using System.Collections.Generic;
using System.Linq;
using Project.Scripts.Core.Presenter;
using Project.Scripts.Game.Areas.Messages.Model;
using Project.Scripts.Game.Areas.Messages.Presenter;
using Project.Scripts.Game.Areas.Messages.View;
using Project.Scripts.Game.Areas.Messengers.Model;
using Project.Scripts.Game.Areas.Messengers.View;
using Project.Scripts.Game.Base.Config;

namespace Project.Scripts.Game.Areas.Messengers.Presenter
{
    public class MessengerPresenter : IPresenter
    {
        private readonly IMessengerModel _model;
        private readonly IMessengerView _view;
        private readonly IGameConfig _gameConfig;
        private readonly Dictionary<IMessageModel, IPresenter> _messagePresenters = new();

        public MessengerPresenter(IMessengerModel model, IMessengerView view, IGameConfig gameConfig)
        {
            _model = model;
            _view = view;
            _gameConfig = gameConfig;

            AddListeners();
            RenderView();
        }

        private void RenderView()
        {
            _view.DisplaySettings(false);
        }

        private void AddListeners()
        {
            _view.ApproveClicked += OnApproveClicked;
            _view.RemoveClicked += OnRemoveClicked;
            _view.SendClicked += OnSendClicked;
            _model.OtherSent += OnOtherSent;
            _model.OwnerSent += OnOwnerSent;
            _model.SettingDisplayed += OnSettingDisplayed;
            _model.MessageRemoved += OnMessageRemoved;
        }

        private void RemoveListeners()
        {
            _view.ApproveClicked -= OnApproveClicked;
            _view.RemoveClicked -= OnRemoveClicked;
            _view.SendClicked -= OnSendClicked;
            _model.OtherSent -= OnOtherSent;
            _model.OwnerSent -= OnOwnerSent;
            _model.SettingDisplayed -= OnSettingDisplayed;
            _model.MessageRemoved -= OnMessageRemoved;
        }

        private void OnApproveClicked()
        {
            _model.DisplaySetting(false);
        }

        private void OnRemoveClicked()
        {
            _model.DisplaySetting(true);
        }

        private void OnSendClicked()
        {
            _model.Send(_view.InputText);
            _view.InputText = "";
        }

        private void OnOtherSent(IMessageModel model)
        {
            CreateMessagePresenter(model, _view.GetOtherMessageCreator().Create());
        }

        private void OnOwnerSent(IMessageModel model)
        {
            CreateMessagePresenter(model, _view.GetOwnerMessageCreator().Create());
        }

        private void CreateMessagePresenter(IMessageModel model, IMessageView view)
        {
            var userConfig = _gameConfig.Users.Users.First(i => i.Id == model.User.Id);
            _messagePresenters.Add(model, new MessagePresenter(model, view, userConfig));
        }

        private void OnSettingDisplayed(bool isDisplay)
        {
            _view.DisplaySettings(isDisplay);
        }

        private void OnMessageRemoved(IMessageModel model)
        {
            var presenter = _messagePresenters[model];
            _messagePresenters.Remove(model);
            presenter.Dispose();
        }

        public void Dispose()
        {
            RemoveListeners();

            foreach (var presenter in _messagePresenters.Values)
            {
                presenter.Dispose();
            }

            _messagePresenters.Clear();
            _view.Dispose();
        }
    }
}