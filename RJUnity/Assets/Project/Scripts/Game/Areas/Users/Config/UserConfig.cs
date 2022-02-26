using System;
using UnityEngine;

namespace Project.Scripts.Game.Areas.Users.Config
{
    [Serializable]
    public class UserConfig : IUserConfig
    {
        [SerializeField] private int _id;
        [SerializeField] private string _nickName;

        public int Id => _id;
        public string NickName => _nickName;
    }
}