using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsBackButtonScript : MonoBehaviour
{

    public Button backButton;
    AudioSource buttonPressSound;

    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(BackButtonAction);
        buttonPressSound = GetComponent<AudioSource>();
    }

    private void Awake()
    {
        GameObject.FindGameObjectWithTag("MusicSlider").GetComponent<Slider>().value = SettingsScript.musicVolume;
        GameObject.FindGameObjectWithTag("SFXSlider").GetComponent<Slider>().value = SettingsScript.sfxVolume;
        GameObject.FindGameObjectWithTag("BrightnessSlider").GetComponent<Slider>().value = SettingsScript.brightness;
        GameObject.FindGameObjectWithTag("LanguageMenu").GetComponent<Dropdown>().value = SettingsScript.languageNum;
        GameObject.FindGameObjectWithTag("ShootButtonMenu").GetComponent<Dropdown>().value = SettingsScript.shootButtonNum;
    }

    private void Update()
    {
        buttonPressSound.volume = SettingsScript.sfxVolume;
    }

    private void BackButtonAction()
    {
        SettingsScript.UpdateValues();
        buttonPressSound.Play();
        StartCoroutine(LoadNextScene("Menu"));
    }

    IEnumerator LoadNextScene(string sceneName)
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
