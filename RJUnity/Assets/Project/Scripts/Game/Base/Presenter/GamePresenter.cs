using Project.Scripts.Game.Areas.Messengers.Presenter;
using Project.Scripts.Game.Base.Config;
using Project.Scripts.Game.Base.Model;
using Project.Scripts.Game.Base.View;

namespace Project.Scripts.Game.Base.Presenter
{
    public class GamePresenter
    {
        public GamePresenter(IGameModel model, IGameView view, IGameConfig config)
        {
            var messenger = new MessengerPresenter(model.Messenger, view.Messenger, config);
        }
    }
}