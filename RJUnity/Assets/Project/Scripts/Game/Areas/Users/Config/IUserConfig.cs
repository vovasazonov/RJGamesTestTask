using UnityEngine;

namespace Project.Scripts.Game.Areas.Users.Config
{
    public interface IUserConfig
    {
        int Id { get; }
        string NickName { get; }
        Sprite ProfileSprite { get; }
    }
}