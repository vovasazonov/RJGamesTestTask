using Project.Scripts.Game.Areas.Users.Config;

namespace Project.Scripts.Game.Base.Config
{
    public interface IGameConfig
    {
        IUsersConfig Users { get; }
    }
}