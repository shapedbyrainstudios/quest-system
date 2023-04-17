using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldManager : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] private int startingGold = 5;

    public int currentGold { get; private set; }

    private void Start() 
    {
        currentGold = startingGold;
        
        GameEventsManager.instance.goldEvents.onGoldGained += GoldGained;

        GameEventsManager.instance.goldEvents.GoldChange(currentGold);
    }

    private void OnDestroy() 
    {
        GameEventsManager.instance.goldEvents.onGoldGained -= GoldGained;
    }

    private void GoldGained(int gold) 
    {
        currentGold += gold;
        GameEventsManager.instance.goldEvents.GoldChange(currentGold);
    }
}
