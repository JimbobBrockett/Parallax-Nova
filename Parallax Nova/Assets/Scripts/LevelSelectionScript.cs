using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectionScript : MonoBehaviour
{

    public Button levelOneButton, levelTwoButton, levelThreeButton, backButton;
    public static bool levelOneComplete = false, levelTwoComplete = false;
    AudioSource buttonPressSound;

    // Start is called before the first frame update
    void Start()
    {
        levelOneButton.onClick.AddListener(LevelOneButtonAction);
        levelTwoButton.onClick.AddListener(LevelTwoButtonAction);
        levelThreeButton.onClick.AddListener(LevelThreeButtonAction);
        backButton.onClick.AddListener(BackButtonAction);
        buttonPressSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        buttonPressSound.volume = SettingsScript.sfxVolume;
        if (!levelOneComplete)
        {
            levelTwoButton.enabled = false;
        }
        else
        {
            levelTwoButton.enabled = true;
        }
        if (!levelTwoComplete)
        {
            levelThreeButton.enabled = false;
        }
        else
        {
            levelThreeButton.enabled = true;
        }
    }

    private void LevelOneButtonAction()
    {
        buttonPressSound.Play();
        StartCoroutine(LoadNextScene("Level1"));
    }

    private void LevelTwoButtonAction()
    {
        buttonPressSound.Play();
        StartCoroutine(LoadNextScene("Level2"));
    }

    private void LevelThreeButtonAction()
    {
        buttonPressSound.Play();
        StartCoroutine(LoadNextScene("Level3"));
    }

    private void BackButtonAction()
    {
        buttonPressSound.Play();
        StartCoroutine(LoadNextScene("Menu"));
    }

    IEnumerator LoadNextScene(string sceneName)
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
