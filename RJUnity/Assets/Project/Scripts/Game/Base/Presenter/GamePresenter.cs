using System;
using System.Collections.Generic;
using Project.Scripts.Game.Areas.Messengers.Presenter;
using Project.Scripts.Game.Base.Config;
using Project.Scripts.Game.Base.Model;
using Project.Scripts.Game.Base.View;

namespace Project.Scripts.Game.Base.Presenter
{
    public class GamePresenter : IDisposable
    {
        private readonly List<IDisposable> _presenters = new();
        
        public GamePresenter(IGameModel model, IGameView view, IGameConfig config)
        {
            _presenters.Add(new MessengerPresenter(model.Messenger, view.Messenger, config));
        }

        public void Dispose()
        {
            foreach (var presenter in _presenters)
            {
                presenter.Dispose();
            }
            
            _presenters.Clear();
        }
    }
}