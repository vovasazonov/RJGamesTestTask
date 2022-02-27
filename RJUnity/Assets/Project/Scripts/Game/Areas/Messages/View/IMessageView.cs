using System;
using UnityEngine;

namespace Project.Scripts.Game.Areas.Messages.View
{
    public interface IMessageView
    {
        event Action RemovedClicked;
        
        Sprite Sprite { set; }
        string NickName { set; }
        string Text { set; }
        DateTime Time { set; }

        void DisplaySetting(bool isDisplay);
        void Remove();
    }
}