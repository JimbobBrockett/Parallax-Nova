using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAudioScript : MonoBehaviour
{
    AudioSource menuAudio;

    void Start()
    {
        // Temporary Solution to Set the initial Values
        menuAudio = GetComponent<AudioSource>();
        SettingsScript.musicVolume = 0.5f;
        SettingsScript.sfxVolume = 0.5f;
    }

    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "Level1" || SceneManager.GetActiveScene().name == "Level2" || SceneManager.GetActiveScene().name == "Level3" || SceneManager.GetActiveScene().name == "Credits")
        {
            Destroy(gameObject);
        }
        if (GameObject.FindGameObjectsWithTag("MenuMusicController").Length > 1)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        menuAudio.volume = SettingsScript.musicVolume;

        if (SceneManager.GetActiveScene().name == "Level1" || SceneManager.GetActiveScene().name == "Level2" || SceneManager.GetActiveScene().name == "Level3" || SceneManager.GetActiveScene().name == "Credits")
        {
            menuAudio.Pause();
        }
        else
        {
            if (!menuAudio.isPlaying)
            {
                menuAudio.Play();
            }
        }
    }
}
