using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class SettingsScript
{

    public static float musicVolume, sfxVolume, brightness;
    public static int languageNum, shootButtonNum;

    // Start is called before the first frame update
    public static void Awake()
    {
        
    }

    public static void UpdateValues()
    {
        musicVolume = GameObject.FindGameObjectWithTag("MusicSlider").GetComponent<Slider>().value;
        sfxVolume = GameObject.FindGameObjectWithTag("SFXSlider").GetComponent<Slider>().value;
        brightness = GameObject.FindGameObjectWithTag("BrightnessSlider").GetComponent<Slider>().value;
        languageNum = GameObject.FindGameObjectWithTag("LanguageMenu").GetComponent<Dropdown>().value;
        shootButtonNum = GameObject.FindGameObjectWithTag("ShootButtonMenu").GetComponent<Dropdown>().value;
    }
}
