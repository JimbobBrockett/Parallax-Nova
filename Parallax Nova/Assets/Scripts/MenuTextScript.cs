using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuTextScript : MonoBehaviour
{

    Text playButtonText, settingsButtonText, creditsButtonText;
    private RectTransform rectTrans;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "PlayButtonText")
        {
            playButtonText = GetComponent<Text>();
        }
        else if (gameObject.name == "SettingsButtonText")
        {
            settingsButtonText = GetComponent<Text>();
        }
        else if (gameObject.name == "CreditsButtonText")
        {
            creditsButtonText = GetComponent<Text>();
        }
        rectTrans = GetComponent<RectTransform>();
        rectTrans.localScale = new Vector3(0.5f, 0.5f, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (SettingsScript.languageNum == 0)
        {
            if (gameObject.name == "PlayButtonText")
            {
                playButtonText.text = "Play";
            }
            else if (gameObject.name == "SettingsButtonText")
            {
                settingsButtonText.text = "Settings";
            }
            else if (gameObject.name == "CreditsButtonText")
            {
                creditsButtonText.text = "Credits";
            }
        }
        else if (SettingsScript.languageNum == 1)
        {
            if (gameObject.name == "PlayButtonText")
            {
                playButtonText.text = "Jouer";
            }
            else if (gameObject.name == "SettingsButtonText")
            {
                settingsButtonText.text = "Paramètres";
            }
            else if (gameObject.name == "CreditsButtonText")
            {
                creditsButtonText.text = "Crédits";
            }
        }
        else if (SettingsScript.languageNum == 2)
        {
            if (gameObject.name == "PlayButtonText")
            {
                playButtonText.text = "Spielen";
            }
            else if (gameObject.name == "SettingsButtonText")
            {
                settingsButtonText.text = "Optionen";
            }
            else if (gameObject.name == "CreditsButtonText")
            {
                creditsButtonText.text = "Credits";
            }
        }
    }
}
