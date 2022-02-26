using Project.Scripts.Game.Areas.Messages.Model;
using Project.Scripts.Game.Areas.Messages.View;

namespace Project.Scripts.Game.Areas.Messages.Presenter
{
    public class MessagesPresenter
    {
        private readonly IMessagesModel _model;
        private readonly IMessagesView _view;

        public MessagesPresenter(IMessagesModel model, IMessagesView view)
        {
            _model = model;
            _view = view;
        }
    }
}