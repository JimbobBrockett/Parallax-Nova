using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIControlScript : MonoBehaviour
{

    private int score = 0;
    private int level = 1;
    private int wave = 1;
    Text scoreText, levelWaveText, playerHPText;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.CompareTag("ScoreText"))
        {
            scoreText = GetComponent<Text>();
        }
        else if (gameObject.CompareTag("LevelWaveText"))
        {
            levelWaveText = GetComponent<Text>();
        }
        else if (gameObject.CompareTag("PlayerHPText"))
        {
            playerHPText = GetComponent<Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SettingsScript.languageNum == 0)
        {
            if (gameObject.CompareTag("ScoreText"))
            {
                scoreText.text = "Score: " + score;
            }
            else if (gameObject.CompareTag("LevelWaveText"))
            {
                if (SceneManager.GetActiveScene().name == "Level1")
                {
                    level = 1;
                }
                else if (SceneManager.GetActiveScene().name == "Level2")
                {
                    level = 2;
                }
                else if (SceneManager.GetActiveScene().name == "Level3")
                {
                    level = 3;
                }
                levelWaveText.text = "Level: " + level + " Wave: " + wave;
            }
            else if (gameObject.CompareTag("PlayerHPText"))
            {
                if (GameObject.FindGameObjectWithTag("Player"))
                {
                    playerHPText.text = "HP: " + GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControlScript>().GetHP();
                }
                else
                {
                    StartCoroutine(DeathReset());
                }
            }
        }
        else if (SettingsScript.languageNum == 1)
        {
            if (gameObject.CompareTag("ScoreText"))
            {
                scoreText.text = "Score: " + score;
            }
            else if (gameObject.CompareTag("LevelWaveText"))
            {
                if (SceneManager.GetActiveScene().name == "Level1")
                {
                    level = 1;
                }
                else if (SceneManager.GetActiveScene().name == "Level2")
                {
                    level = 2;
                }
                else if (SceneManager.GetActiveScene().name == "Level3")
                {
                    level = 3;
                }
                levelWaveText.text = "Niveau: " + level + " Vague: " + wave;
            }
            else if (gameObject.CompareTag("PlayerHPText"))
            {
                if (GameObject.FindGameObjectWithTag("Player"))
                {
                    playerHPText.text = "PV: " + GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControlScript>().GetHP();
                }
                else
                {
                    StartCoroutine(DeathReset());
                }
            }
        }
        else if (SettingsScript.languageNum == 2)
        {
            if (gameObject.CompareTag("ScoreText"))
            {
                scoreText.text = "Score: " + score;
            }
            else if (gameObject.CompareTag("LevelWaveText"))
            {
                if (SceneManager.GetActiveScene().name == "Level1")
                {
                    level = 1;
                }
                else if (SceneManager.GetActiveScene().name == "Level2")
                {
                    level = 2;
                }
                else if (SceneManager.GetActiveScene().name == "Level3")
                {
                    level = 3;
                }
                levelWaveText.text = "Level: " + level + " Welle: " + wave;
            }
            else if (gameObject.CompareTag("PlayerHPText"))
            {
                if (GameObject.FindGameObjectWithTag("Player"))
                {
                    playerHPText.text = "HP: " + GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControlScript>().GetHP();
                }
                else
                {
                    StartCoroutine(DeathReset());
                }
            }
        }
    }

    public void AddScore()
    {
        score++;
    }

    public void NextWave()
    {
        wave++;
    }

    IEnumerator DeathReset()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("LevelSelection", LoadSceneMode.Single);
    }
}
