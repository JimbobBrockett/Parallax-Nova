using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionTextScript : MonoBehaviour
{

    Text levelOneButtonText, levelTwoButtonText, levelThreeButtonText, backButtonText;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "Level1ButtonText")
        {
            levelOneButtonText = GetComponent<Text>();
        }
        else if (gameObject.name == "Level2ButtonText")
        {
            levelTwoButtonText = GetComponent<Text>();
        }
        else if (gameObject.name == "Level3ButtonText")
        {
            levelThreeButtonText = GetComponent<Text>();
        }
        else if (gameObject.name == "BackButtonText")
        {
            backButtonText = GetComponent<Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SettingsScript.languageNum == 0)
        {
            if (gameObject.name == "Level1ButtonText")
            {
                levelOneButtonText.text = "Level 1";
            }
            else if (gameObject.name == "Level2ButtonText")
            {
                levelTwoButtonText.text = "Level 2";
            }
            else if (gameObject.name == "Level3ButtonText")
            {
                levelThreeButtonText.text = "Level 3";
            }
            else if (gameObject.name == "BackButtonText")
            {
                backButtonText.text = "Back";
            }
        }
        else if (SettingsScript.languageNum == 1)
        {
            if (gameObject.name == "Level1ButtonText")
            {
                levelOneButtonText.text = "Niveau 1";
            }
            else if (gameObject.name == "Level2ButtonText")
            {
                levelTwoButtonText.text = "Niveau 2";
            }
            else if (gameObject.name == "Level3ButtonText")
            {
                levelThreeButtonText.text = "Niveau 3";
            }
            else if (gameObject.name == "BackButtonText")
            {
                backButtonText.text = "Retour";
            }
        }
        else if (SettingsScript.languageNum == 2)
        {
            if (gameObject.name == "Level1ButtonText")
            {
                levelOneButtonText.text = "Level 1";
            }
            else if (gameObject.name == "Level2ButtonText")
            {
                levelTwoButtonText.text = "Level 2";
            }
            else if (gameObject.name == "Level3ButtonText")
            {
                levelThreeButtonText.text = "Level 3";
            }
            else if (gameObject.name == "BackButtonText")
            {
                backButtonText.text = "Zurück";
            }
        }
    }
}
