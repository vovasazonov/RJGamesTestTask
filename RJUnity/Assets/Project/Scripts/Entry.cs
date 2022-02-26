using Project.Scripts.Game;
using Project.Scripts.Game.Base.Config;
using UnityEngine;

public class Entry : MonoBehaviour
{
    [SerializeField] private GameConfig _config;
    
    private Game _game;
    
    void Start()
    {
        _game = new Game(_config);
    }
}
