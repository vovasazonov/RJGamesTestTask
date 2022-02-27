using Project.Scripts.Game.Areas.Messengers.Model;
using Project.Scripts.Game.Areas.Messengers.View;

namespace Project.Scripts.Game.Areas.Messengers.Presenter
{
    public class MessengerPresenter
    {
        private readonly IMessengerModel _model;
        private readonly IMessengerView _view;

        public MessengerPresenter(IMessengerModel model, IMessengerView view)
        {
            _model = model;
            _view = view;
        }
    }
}