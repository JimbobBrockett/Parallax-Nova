using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsScript : MonoBehaviour
{
    RectTransform currentPosition;
    Text creditsTextContent;

    void Start()
    {
        currentPosition = GetComponent<RectTransform>();
        currentPosition.localPosition = new Vector3(0, -1150, 0);
        creditsTextContent = GetComponent<Text>();
    }

    void Update()
    {
        currentPosition.localPosition = new Vector3(0, currentPosition.localPosition.y + (15.00f * Time.deltaTime), 0);

        if (currentPosition.localPosition.y > 1150)
        {
            StartCoroutine(EndOfSong());
        }

        if (SettingsScript.languageNum == 0)
        {
            creditsTextContent.text = 
                "Parallax Nova\n" +
                "\n" +
                "Team Coordinator\n" +
                "MartinJimbobBrockett\n" +
                "\n" +
                "Lead Programmer\n" +
                "MartinJimbobBrockett\n" +
                "\n" +
                "Lead Asset Design and Creation\n" +
                "Brian Lätt (VerzatileDev)\n" +
                "\n" +
                "Lead Sound Design\n" +
                "PEGONTHETRACK\n" +
                "\n" +
                "Sound Design Assistant\n" +
                "Darkxiety\n" +
                "\n" +
                "Translators\n" +
                "\n" +
                "German\n" +
                "Nina Menke\n" +
                "\n" +
                "French\n" +
                "Charlie Finney\n" +
                "\n" +
                "Made In Unity\n" +
                "Models Created in Blender\n" +
                "Music Created in FLStudio\n" +
                "\n" +
                "Special Thanks To\n" +
                "The ASDA Delivery guy\n" +
                "Just Eat\n" +
                "Dodo Pizza\n" +
                "Uber Eats\n" +
                "Tefal and their frying pans\n" +
                "Relentless\n" +
                "Coca Cola\n" +
                "GIGABYTE\n" +
                "Brian who held it together through the War of The Bones\n" +
                "The entire SoundHub Discord Server\n" +
                "Rick Astley for not giving me up\n" +
                "Chris for getting the French translations for me\n" +
                "Everyone who messaged and supported\n" +
                "Mike Richards for hosting another amazing Global Game Jam\n" +
                "Will Blewitt and Ian Evans for being amazing staff members\n" +
                "Zoom for actually letting all of us at once watch the intro video\n" +
                "Nvidia for making epic graphics cards\n" +
                "My housemate Finley for being funny moral support\n" +
                "Toto for blessing the rains down in Africa\n" +
                "Douwe Egberts for the best instant coffee\n" +
                "Me for not having a complete mental shutdown\n" +
                "Also me for not trying to make a JRPG this time\n" +
                "\n" +
                "And finally...\n" +
                "Global Game Jam themselves!\n" +
                "\n" +
                "\n" +
                "\n" +
                "Thanks for playing! <3\n";
        }
        else if (SettingsScript.languageNum == 1)
        {
            creditsTextContent.text =
                "Parallax Nova\n" +
                "\n" +
                "Coordinateur d'équipe\n" +
                "MartinJimbobBrockett\n" +
                "\n" +
                "Programmeur principal\n" +
                "MartinJimbobBrockett\n" +
                "\n" +
                "Concepteur et Créateur principal d'atout\n" +
                "Brian Lätt (VerzatileDev)\n" +
                "\n" +
                "Créateur principal de son\n" +
                "PEGONTHETRACK\n" +
                "\n" +
                "Assistant de conception de son\n" +
                "Darkxiety\n" +
                "\n" +
                "Traducteurs\n" +
                "\n" +
                "Allemand\n" +
                "Nina Menke\n" +
                "\n" +
                "Français\n" +
                "Charlie Finney\n" +
                "\n" +
                "Made In Unity\n" +
                "Models Created in Blender\n" +
                "Music Created in FLStudio\n" +
                "\n" +
                "Special Thanks To\n" +
                "The ASDA Delivery guy\n" +
                "Just Eat\n" +
                "Dodo Pizza\n" +
                "Uber Eats\n" +
                "Tefal and their frying pans\n" +
                "Relentless\n" +
                "Coca Cola\n" +
                "GIGABYTE\n" +
                "Brian who held it together through the War of The Bones\n" +
                "The entire SoundHub Discord Server\n" +
                "Rick Astley for not giving me up\n" +
                "Chris for getting the French translations for me\n" +
                "Everyone who messaged and supported\n" +
                "Mike Richards for hosting another amazing Global Game Jam\n" +
                "Will Blewitt and Ian Evans for being amazing staff members\n" +
                "Zoom for actually letting all of us at once watch the intro video\n" +
                "Nvidia for making epic graphics cards\n" +
                "My housemate Finley for being funny moral support\n" +
                "Toto for blessing the rains down in Africa\n" +
                "Douwe Egberts for the best instant coffee\n" +
                "Me for not having a complete mental shutdown\n" +
                "Also me for not trying to make a JRPG this time\n" +
                "\n" +
                "And finally...\n" +
                "Global Game Jam themselves!\n" +
                "\n" +
                "\n" +
                "\n" +
                "Thanks for playing! <3\n";
        }
        else if (SettingsScript.languageNum == 2)
        {
            creditsTextContent.text =
                "Parallax Nova\n" +
                "\n" +
                "Teamkoordination\n" +
                "MartinJimbobBrockett\n" +
                "\n" +
                "Leitung Programmierung\n" +
                "MartinJimbobBrockett\n" +
                "\n" +
                "Leitung Asset Design und Creation\n" +
                "Brian Lätt (VerzatileDev)\n" +
                "\n" +
                "Leitung Sound Design\n" +
                "PEGONTHETRACK\n" +
                "\n" +
                "Assistenz Sound Design\n" +
                "Darkxiety\n" +
                "\n" +
                "Übersetzer\n" +
                "\n" +
                "Deutsch\n" +
                "Nina Menke\n" +
                "\n" +
                "Französisch\n" +
                "Charlie Finney" +
                "\n" +
                "Made In Unity\n" +
                "Models Created in Blender\n" +
                "Music Created in FLStudio\n" +
                "\n" +
                "Special Thanks To\n" +
                "The ASDA Delivery guy\n" +
                "Just Eat\n" +
                "Dodo Pizza\n" +
                "Uber Eats\n" +
                "Tefal and their frying pans\n" +
                "Relentless\n" +
                "Coca Cola\n" +
                "GIGABYTE\n" +
                "Brian who held it together through the War of The Bones\n" +
                "The entire SoundHub Discord Server\n" +
                "Rick Astley for not giving me up\n" +
                "Chris for getting the French translations for me\n" +
                "Everyone who messaged and supported\n" +
                "Mike Richards for hosting another amazing Global Game Jam\n" +
                "Will Blewitt and Ian Evans for being amazing staff members\n" +
                "Zoom for actually letting all of us at once watch the intro video\n" +
                "Nvidia for making epic graphics cards\n" +
                "My housemate Finley for being funny moral support\n" +
                "Toto for blessing the rains down in Africa\n" +
                "Douwe Egberts for the best instant coffee\n" +
                "Me for not having a complete mental shutdown\n" +
                "Also me for not trying to make a JRPG this time\n" +
                "\n" +
                "And finally...\n" +
                "Global Game Jam themselves!\n" +
                "\n" +
                "\n" +
                "\n" +
                "Thanks for playing! <3\n";
        }
    }

    IEnumerator EndOfSong()
    {
        GameObject.FindGameObjectWithTag("Ship").GetComponent<CreditsPlanetAndShipScript>().creditsOver = true;
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
