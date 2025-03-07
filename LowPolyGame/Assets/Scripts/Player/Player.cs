using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController controller;
    public PlayerStat stat;

    public ItemData itemData;
    public Action addItem;

    private void Awake()
    {
        PlayerManager.Instance.Player = this;
        controller = GetComponent<PlayerController>();
        stat = GetComponent<PlayerStat>();
    }

}
