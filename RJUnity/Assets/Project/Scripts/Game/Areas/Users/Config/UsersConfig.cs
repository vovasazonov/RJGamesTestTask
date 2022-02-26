using System;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Scripts.Game.Areas.Users.Config
{
    [Serializable]
    public class UsersConfig : IUsersConfig
    {
        [SerializeField] private List<UserConfig> _users;
        [SerializeField] private int _ownerUserId;

        public IEnumerable<IUserConfig> Users => _users;
        public int OwnerUserId => _ownerUserId;
    }
}