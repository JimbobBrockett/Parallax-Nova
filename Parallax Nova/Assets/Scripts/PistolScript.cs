using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PistolScript : MonoBehaviour
{

    AudioSource victoryTheme;

    // Start is called before the first frame update
    void Start()
    {
        victoryTheme = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        victoryTheme.volume = SettingsScript.musicVolume;
        transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * 30);
        if (transform.position.y > 0)
        {
            transform.position = new Vector3(0, transform.position.y - 0.01f, transform.position.z);
        }
        else
        {
            if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().isPlaying)
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().Stop();
            }
            if (!victoryTheme.isPlaying)
            {
                victoryTheme.Play();
            }
            StartCoroutine(BackToLevelSelection());
        }
    }

    IEnumerator BackToLevelSelection()
    {
        yield return new WaitForSeconds(5);
        LevelSelectionScript.levelTwoComplete = true;
        SceneManager.LoadScene("LevelSelection", LoadSceneMode.Single);
    }
}
