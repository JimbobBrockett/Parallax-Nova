using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAudioScript : MonoBehaviour
{

    AudioSource menuAudio;

    // Start is called before the first frame update
    void Start()
    {
        menuAudio = GetComponent<AudioSource>();
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

    // Update is called once per frame
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
