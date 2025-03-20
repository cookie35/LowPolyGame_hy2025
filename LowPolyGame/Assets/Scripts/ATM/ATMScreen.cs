using TMPro;
using UnityEngine;

public class ATMScreen : MonoBehaviour
{
    public GameObject atmWindow;

    [Header("PopupBank")]
    public TextMeshProUGUI balance;  // ���� �ܰ� ����
    public TextMeshProUGUI cash; // ���� �ִ� ����
    public GameObject depositButton;  // �Ա� ��ư
    public GameObject withdrawButton;  // ��� ��ư

    public int currentBalance = 50000;
    public int currentCash = 100000;
    
    void Start()
    {
        UpdateAtmDisplay();
    }

    // Update is called once per frame
    void UpdateAtmDisplay()
    {
        balance.text = string.Format("{0:N0}", currentBalance); 
        cash.text = string.Format("{0:N0}", currentCash);
    }
}
