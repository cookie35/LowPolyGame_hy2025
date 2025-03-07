using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Interactable
{
    public string GetInteractPrompt();
    public void OnInteract();
}

public class ItemObject : MonoBehaviour, Interactable
{
    public ItemData data;

    public string GetInteractPrompt()
    {
        string str = $"{data.displayName}\n{data.description}";
        return str;
    }

    public void OnInteract()
    {
        PlayerManager.Instance.Player.itemData = data;
        PlayerManager.Instance.Player.addItem?.Invoke();
    }
    
}
