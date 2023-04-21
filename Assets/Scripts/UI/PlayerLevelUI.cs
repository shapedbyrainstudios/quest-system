using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerLevelUI : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Slider xpSlider;
    [SerializeField] private TextMeshProUGUI xpText;
    [SerializeField] private TextMeshProUGUI levelText;

    private void OnEnable()
    {
        GameEventsManager.instance.playerEvents.onPlayerExperienceChange += PlayerExperienceChange;
        GameEventsManager.instance.playerEvents.onPlayerLevelChange += PlayerLevelChange;
    }

    private void OnDisable() 
    {
        GameEventsManager.instance.playerEvents.onPlayerExperienceChange -= PlayerExperienceChange;
        GameEventsManager.instance.playerEvents.onPlayerLevelChange -= PlayerLevelChange;
    }

    private void PlayerExperienceChange(int experience) 
    {
        xpSlider.value = (float) experience / (float) 100;
        xpText.text = experience + " / " + GlobalConstants.experienceToLevelUp;
    }

    private void PlayerLevelChange(int level) 
    {
        levelText.text = "Level " + level;
    }
}
