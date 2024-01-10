using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{

    SpriteRenderer backgroundImage, logoImage;
    private bool fade = false;

    // Start is called before the first frame update
    void Start()
    {
        SettingsScript.musicVolume = 1;
        SettingsScript.sfxVolume = 1;
        SettingsScript.brightness = 1;

        backgroundImage = GameObject.FindGameObjectWithTag("BackgroundImage").GetComponent<SpriteRenderer>();
        backgroundImage.color = new Color(backgroundImage.color.r, backgroundImage.color.g, backgroundImage.color.b, 0);

        logoImage = GameObject.FindGameObjectWithTag("Logo").GetComponent<SpriteRenderer>();
        logoImage.color = new Color(backgroundImage.color.r, backgroundImage.color.g, backgroundImage.color.b, 0);
    }

    // Update is called once per frame
    void Update()
    {
        backgroundImage.color = new Color(backgroundImage.color.r, backgroundImage.color.g, backgroundImage.color.b, backgroundImage.color.a + 0.0003f);
        StartCoroutine(GoToMenu());

        if (!fade)
        {
            logoImage.color = new Color(logoImage.color.r, logoImage.color.g, logoImage.color.b, logoImage.color.a + 0.0005f);
            if (logoImage.color.a >= 1)
            {
                fade = true;
            }
        }
        else
        {
            logoImage.color = new Color(logoImage.color.r, logoImage.color.g, logoImage.color.b, logoImage.color.a - 0.0005f);
        }
    }

    IEnumerator GoToMenu()
    {
        yield return new WaitForSeconds(28);
        SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
    }
}
