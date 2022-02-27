using Project.Scripts.Game.Areas.Messengers.View;
using UnityEngine;

namespace Project.Scripts.Game.Base.View
{
    public class GameView : MonoBehaviour, IGameView
    {
        [SerializeField] private MessengerView _messenger;

        public IMessengerView Messenger => _messenger;
    }
}