using System;
using Project.Scripts.Game.Areas.Messages.View;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Project.Scripts.Game.Areas.Messengers.View
{
    public class MessengerView : MonoBehaviour, IMessengerView
    {
        [SerializeField] private MessageView _ownerMessagePrefab;
        [SerializeField] private MessageView _otherMessagePrefab;
        [SerializeField] private Transform _messagesParent;
        [SerializeField] private TMP_InputField _inputField;
        [SerializeField] private Button _sendButton;
        [SerializeField] private Button _approveButton;
        [SerializeField] private Button _removeButton;
        [SerializeField] private Animator _contentAnimator;

        public event Action SendClicked;
        public event Action RemoveClicked;
        public event Action ApproveClicked;

        public string InputText
        {
            get => _inputField.text;
            set => _inputField.text = value;
        }

        private void OnEnable()
        {
            _sendButton.onClick.AddListener(CallSendClicked);
            _removeButton.onClick.AddListener(CallRemoveClicked);
            _approveButton.onClick.AddListener(CallApproveClicked);
        }

        private void OnDisable()
        {
            _sendButton.onClick.RemoveListener(CallSendClicked);
            _removeButton.onClick.RemoveListener(CallRemoveClicked);
            _approveButton.onClick.RemoveListener(CallApproveClicked);
        }

        public IMessageView CreateOwner()
        {
            return CreateMessage(_ownerMessagePrefab);
        }

        public IMessageView CreateOther()
        {
            return CreateMessage(_otherMessagePrefab);
        }

        public void DisplaySettings(bool isDisplay)
        {
            _approveButton.gameObject.SetActive(isDisplay);
            _sendButton.gameObject.SetActive(!isDisplay);
            _removeButton.gameObject.SetActive(!isDisplay);
            _inputField.gameObject.SetActive(!isDisplay);
            _contentAnimator.Play(isDisplay ? "DisplayOnSetting" : "DisplayOffSetting");
        }

        private IMessageView CreateMessage(MessageView prefab)
        {
            return Instantiate(prefab, _messagesParent);
        }

        private void CallSendClicked()
        {
            SendClicked?.Invoke();
        }

        private void CallRemoveClicked()
        {
            RemoveClicked?.Invoke();
        }

        private void CallApproveClicked()
        {
            ApproveClicked?.Invoke();
        }
    }
}