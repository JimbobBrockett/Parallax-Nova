using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsTextScript : MonoBehaviour
{

    Text musicVolumeText, sfxVolumeText, languageText, brightnessText, shootText, backButtonText;
    Dropdown languageMenu, shootMenu;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "MusicVolumeText")
        {
            musicVolumeText = GetComponent<Text>();
        }
        else if (gameObject.name == "SFXVolumeText")
        {
            sfxVolumeText = GetComponent<Text>();
        }
        else if (gameObject.name == "LanguageText")
        {
            languageText = GetComponent<Text>();
        }
        else if (gameObject.name == "BrightnessText")
        {
            brightnessText = GetComponent<Text>();
        }
        else if (gameObject.name == "ShootText")
        {
            shootText = GetComponent<Text>();
        }
        else if (gameObject.name == "BackButtonText")
        {
            backButtonText = GetComponent<Text>();
        }
        else if (gameObject.name == "LanguageMenu")
        {
            languageMenu = GetComponent<Dropdown>();
        }
        else if (gameObject.name == "ShootMenu")
        {
            shootMenu = GetComponent<Dropdown>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SettingsScript.languageNum == 0)
        {
            if (gameObject.name == "MusicVolumeText")
            {
                musicVolumeText.text = "Music Volume";
            }
            else if (gameObject.name == "SFXVolumeText")
            {
                sfxVolumeText.text = "SFX Volume";
            }
            else if (gameObject.name == "LanguageText")
            {
                languageText.text = "Language";
            }
            else if (gameObject.name == "BrightnessText")
            {
                brightnessText.text = "Brightness";
            }
            else if (gameObject.name == "ShootText")
            {
                shootText.text = "Shoot";
            }
            else if (gameObject.name == "BackButtonText")
            {
                backButtonText.text = "Back";
            }
            else if (gameObject.name == "LanguageMenu")
            {
                languageMenu.options[0].text = "English";
                languageMenu.options[1].text = "French";
                languageMenu.options[2].text = "German";
                languageMenu.RefreshShownValue();
            }
            else if (gameObject.name == "ShootMenu")
            {
                shootMenu.options[0].text = "Space";
                shootMenu.options[1].text = "Left Click";
                shootMenu.RefreshShownValue();
            }
        }
        else if (SettingsScript.languageNum == 1)
        {
            if (gameObject.name == "MusicVolumeText")
            {
                musicVolumeText.text = "Volume de la musique";
            }
            else if (gameObject.name == "SFXVolumeText")
            {
                sfxVolumeText.text = "Volumes des sons";
            }
            else if (gameObject.name == "LanguageText")
            {
                languageText.text = "Langue";
            }
            else if (gameObject.name == "BrightnessText")
            {
                brightnessText.text = "Luminosité";
            }
            else if (gameObject.name == "ShootText")
            {
                shootText.text = "Tirer";
            }
            else if (gameObject.name == "BackButtonText")
            {
                backButtonText.text = "Retour";
            }
            else if (gameObject.name == "LanguageMenu")
            {
                languageMenu.options[0].text = "Anglais";
                languageMenu.options[1].text = "Français";
                languageMenu.options[2].text = "Allemand";
                languageMenu.RefreshShownValue();
            }
            else if (gameObject.name == "ShootMenu")
            {
                shootMenu.options[0].text = "Barre d'espace";
                shootMenu.options[1].text = "Clic Gauche";
                shootMenu.RefreshShownValue();
            }
        }
        else if (SettingsScript.languageNum == 2)
        {
            if (gameObject.name == "MusicVolumeText")
            {
                musicVolumeText.text = "Lautstärke Musik";
            }
            else if (gameObject.name == "SFXVolumeText")
            {
                sfxVolumeText.text = "Lautstärke Soundeffekte";
            }
            else if (gameObject.name == "LanguageText")
            {
                languageText.text = "Sprache";
            }
            else if (gameObject.name == "BrightnessText")
            {
                brightnessText.text = "Helligkeit";
            }
            else if (gameObject.name == "ShootText")
            {
                shootText.text = "Schießen";
            }
            else if (gameObject.name == "BackButtonText")
            {
                backButtonText.text = "Zurück";
            }
            else if (gameObject.name == "LanguageMenu")
            {
                languageMenu.options[0].text = "Englisch";
                languageMenu.options[1].text = "Französisch";
                languageMenu.options[2].text = "Deutsch";
                languageMenu.RefreshShownValue();
            }
            else if (gameObject.name == "ShootMenu")
            {
                shootMenu.options[0].text = "Leertaste";
                shootMenu.options[1].text = "Linksklick";
                shootMenu.RefreshShownValue();
            }
        }
    }
}
