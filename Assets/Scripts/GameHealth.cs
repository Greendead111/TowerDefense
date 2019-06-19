using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHealth : MonoBehaviour
{
    public static GameHealth Instance;
    [SerializeField]
    private TMPro.TMP_Text healthText;
    private int healthLeft;




    void Start()
    {
        if (Instance == null)
            Instance = this;
        healthLeft = 100;
        UpdateHealthUI();
    }



    public void DeductHealth(int amount)
    {
        healthLeft -= amount;
        UpdateHealthUI();
    }



    public void UpdateHealthUI()
    {
        healthText.text = healthLeft.ToString();
    }
}
