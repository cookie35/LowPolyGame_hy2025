using System;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new GameObject("GameManager").AddComponent<GameManager>();
            }
            return _instance;
        }
    }

    private PlayerController _player; // PlayerController를 GameManager에서 관리

    public PlayerController Player
    {
        get { return _player;  }
        set { _player = value; }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (_instance != this)
            {
                Destroy(gameObject);
            }
        }

        InitPlayer();
    }

    private void InitPlayer()  // 플레이어 초기화
    {
        _player = new GameObject("PlayerController").AddComponent<PlayerController>();
    }

    // 게임 로직, 점수, 상태 등 관리

}
