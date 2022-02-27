using System;
using UnityEngine;

namespace Project.Scripts.Game.Areas.Messages.View
{
    public interface IMessageView : IDisposable
    {
        event Action RemovedClicked;
        
        Sprite Sprite { set; }
        string NickName { set; }
        string Text { set; }
        DateTime Time { set; }
        bool IsHighlightBackground { set; }

        void DisplaySetting(bool isDisplay);
    }
}