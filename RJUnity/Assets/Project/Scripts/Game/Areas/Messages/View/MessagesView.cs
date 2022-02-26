using UnityEngine;

namespace Project.Scripts.Game.Areas.Messages.View
{
    public class MessagesView : MonoBehaviour, IMessagesView
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