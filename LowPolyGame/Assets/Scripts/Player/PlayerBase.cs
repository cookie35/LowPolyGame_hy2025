using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    public PlayerController controller;
    public PlayerStat stat;

    private void Awake()
    {
        PlayerManager.Instance.Player = this;
        controller = GetComponent<PlayerController>();
        stat = GetComponent<PlayerStat>();
    }

}
