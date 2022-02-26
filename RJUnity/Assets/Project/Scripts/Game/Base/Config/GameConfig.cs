using Project.Scripts.Game.Areas.Users.Config;
using UnityEngine;

namespace Project.Scripts.Game.Base.Config
{
    [CreateAssetMenu(fileName = "GameConfig", menuName = "ScriptableObjects/GameConfig", order = 1)]
    public class GameConfig : ScriptableObject, IGameConfig
    {
        [SerializeField] private UsersConfig _users;

        public IUsersConfig Users => _users;
    }
}