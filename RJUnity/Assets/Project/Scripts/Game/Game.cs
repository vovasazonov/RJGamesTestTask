using Project.Scripts.Game.Base.Config;
using Project.Scripts.Game.Base.Model;
using Project.Scripts.Game.Base.Presenter;

namespace Project.Scripts.Game
{
    public class Game
    {
        private readonly IGameModel _model;
        private readonly IGameConfig _config;
        private readonly GamePresenter _presenter;
        
        public Game(IGameConfig config)
        {
            _config = config;
            _model = new GameModel(_config);
            _presenter = new GamePresenter(_model, _config);
        }
    }
}