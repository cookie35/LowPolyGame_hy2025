using UnityEngine;

// 각 UI의 상태를 한 번에 업데이트

public class StatUiManager : MonoBehaviour
{
    public StatBar health;
    public StatBar stamina;

    void Start()
    {
        PlayerManager.Instance.Player.stat.statUiManager = this;    
    }

}
