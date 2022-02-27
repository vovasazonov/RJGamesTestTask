using Project.Scripts.Game.Areas.Messages.View;
using UnityEngine;

namespace Project.Scripts.Game.Areas.Messengers.View
{
    public class MessengerView : MonoBehaviour, IMessengerView
    {
        public IMessageView CreateOwner()
        {
            throw new System.NotImplementedException();
        }

        public IMessageView CreateOther()
        {
            throw new System.NotImplementedException();
        }
    }
}