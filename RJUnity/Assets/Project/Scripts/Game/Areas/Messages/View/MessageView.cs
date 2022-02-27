using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Project.Scripts.Game.Areas.Messages.View
{
    public class MessageView : MonoBehaviour, IMessageView
    {
        [SerializeField] private Image _image;
        [SerializeField] private TextMeshProUGUI _nickName;
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private TextMeshProUGUI _time;
        [SerializeField] private Button _removeButton;
        [SerializeField] private Image _background;
        [SerializeField] private Sprite _highlightBackgroundSprite;
        [SerializeField] private Sprite _classicBackgroundSprite;

        public event Action RemovedClicked;

        public Sprite Sprite
        {
            set => _image.sprite = value;
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
            set => _time.text = value.TimeOfDay.ToString(@"hh\:mm\:ss");
        }

        public bool IsHighlightBackground
        {
            set => _background.sprite = value ? _highlightBackgroundSprite : _classicBackgroundSprite;
        }

        private void OnEnable()
        {
            if (_removeButton != null)
            {
                _removeButton.onClick.AddListener(OnRemoveClicked);
            }
        }

        private void OnDisable()
        {
            if (_removeButton != null)
            {
                _removeButton.onClick.RemoveListener(OnRemoveClicked);
            }
        }

        private void OnRemoveClicked()
        {
            CallRemovedClicked();
        }

        public void DisplaySetting(bool isDisplay)
        {
            if (_removeButton != null)
            {
                _removeButton.gameObject.SetActive(isDisplay);
            }
        }

        private void CallRemovedClicked()
        {
            RemovedClicked?.Invoke();
        }

        public void Dispose()
        {
            Destroy(gameObject);
        }
    }
}