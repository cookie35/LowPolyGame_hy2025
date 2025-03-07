using System;
using UnityEngine;

public interface PlayerDamage
{
    void TakePhysicalDamage(int damage);

}

public class PlayerStat : MonoBehaviour, PlayerDamage
{
    public StatUiManager statUiManager;

    StatBar health { get { return statUiManager.health; } }
    StatBar stamina { get { return statUiManager.stamina; } }

    public event Action onTakeDamage;

    void Update()
    {
        stamina.Add(stamina.passiveValue * Time.deltaTime);
        
        if (health.curValue == 0f)
        {
            Die();
        }
    }

    public void Heal(float amount)
    {
        health.Add(amount);
    }

    public void Die()
    {
        Debug.Log("죽었다!");
    }

    public void TakePhysicalDamage(int damage)
    {
        health.Subtract(damage);
        onTakeDamage?.Invoke();
    }
}
