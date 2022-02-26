using System;
using TMPro;
using UnityEngine;

namespace Project.Scripts.Game.Areas.Messages.View
{
    public class MessageView : MonoBehaviour, IMessageView
    {
        [SerializeField] private SpriteRenderer _sprite;
        [SerializeField] private TextMeshProUGUI _nickName;
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private TextMeshProUGUI _time;

        public event Action Removed;

        public Sprite Sprite
        {
            set => _sprite.sprite = value;
        }

        public string NickName
        {
            set => _nickName.text = value;
        }

        public string Text
        {
            set => _text.text = value;
        }

        public DateTime Time
        {
            set => _time.text = value.TimeOfDay.ToString();
        }

        public void DisplaySetting(bool isDisplay)
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            CallRemoved();
            DestroyImmediate(this);
        }

        private void CallRemoved()
        {
            Removed?.Invoke();
        }
    }
}