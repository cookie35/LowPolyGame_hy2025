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
                _instance = new GameManager("GameManager").AddComponent<GameManager>();
            }
            return _instance;
        }
    }

    private Player _player; // Player�� GameManager���� ����

    public Player Player
    {
        get { return  _player  }
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

    private void InitPlayer()  // �÷��̾� �ʱ�ȭ
    {
        _player = new GameObject("Player").AddComponent<Player>();
    }

    // ���� ����, ����, ���� �� ����

}
