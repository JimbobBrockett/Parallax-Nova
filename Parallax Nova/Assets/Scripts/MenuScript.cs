using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public Button playButton, settingsButton, creditsButton;
    AudioSource buttonPressSound;

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(PlayButtonAction);
        settingsButton.onClick.AddListener(SettingsButtonAction);
        creditsButton.onClick.AddListener(CreditsButtonAction);
        buttonPressSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        buttonPressSound.volume = SettingsScript.sfxVolume;
    }

    void PlayButtonAction()
    {
        buttonPressSound.Play();
        StartCoroutine(LoadNextScene("LevelSelection"));
    }

    void SettingsButtonAction()
    {
        buttonPressSound.Play();
        StartCoroutine(LoadNextScene("Settings"));
    }

    void CreditsButtonAction()
    {
        buttonPressSound.Play();
        StartCoroutine(LoadNextScene("Credits"));
    }

    IEnumerator LoadNextScene(string sceneName)
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
