using Project.Scripts.Core.View;
using Project.Scripts.Game.Areas.Messengers.View;
using UnityEngine;

namespace Project.Scripts.Game.Base.View
{
    public class GameView : MonoBehaviour, IGameView
    {
        [SerializeField] private PrimitiveView _cameraPrefab;
        [SerializeField] private PrimitiveView _eventSystemPrefab;
        [SerializeField] private MessengerView _messengerPrefab;
        
        public IViewCreator<IPrimitiveView> Camera { get; private set; }
        public IViewCreator<IPrimitiveView> EventSystem { get; private set; }
        public IViewCreator<IMessengerView> Messenger { get; private set; }

        private void Awake()
        {
            Camera = new ViewCreator<PrimitiveView>(_cameraPrefab);
            EventSystem = new ViewCreator<PrimitiveView>(_eventSystemPrefab);
            Messenger = new ViewCreator<MessengerView>(_messengerPrefab);
        }
    }
}