using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{

    public GameObject enemy, prize;
    private float timer;
    private int[] enemySlots;
    private int waveNumber, rowMax;

    // Start is called before the first frame update
    void Start()
    {
        timer = 5;
        enemySlots = new int[5];
        for (int i = 0; i < 5; i++)
        {
            enemySlots[i] = 0;
        }
        waveNumber = 1;
        rowMax = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (waveNumber < 4)
        {
            timer -= Time.deltaTime;
            if (timer <= 0 && rowMax > 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    enemySlots[i] = 0;
                }
                SpawnEnemy(Random.Range(2, 6));
                timer = 10;
                rowMax--;
            }
            else if (rowMax <= 0)
            {
                StartCoroutine(StartNextWave());
            }
        }
        else
        {
            if (!GameObject.FindGameObjectWithTag("Prize"))
            {
                Instantiate(prize, new Vector3(0, 10, 3), Quaternion.Euler(90, 0, 0));
                GameObject[] EnemiesToKill = GameObject.FindGameObjectsWithTag("Enemy");
                for (int i = 0; i < EnemiesToKill.Length; i++)
                {
                    Destroy(EnemiesToKill[i]);
                }
                gameObject.GetComponent<EnemySpawnScript>().enabled = false;
            }
        }
    }

    private void SpawnEnemy(int numberOfEnemies)
    {
        for (int enemyCount = 0; enemyCount < numberOfEnemies; enemyCount++)
        {
            int slotNum = Random.Range(0, 5);
            if (enemySlots[slotNum] == 0)
            {
                enemySlots[slotNum] = 1;
                if (slotNum == 0)
                {
                    Instantiate(enemy, new Vector3(-6.66f, 6, 0), Quaternion.Euler(-90, 0, 0));
                }
                else if (slotNum == 1)
                {
                    Instantiate(enemy, new Vector3(-3.33f, 6, 0), Quaternion.Euler(-90, 0, 0));
                }
                else if (slotNum == 2)
                {
                    Instantiate(enemy, new Vector3(0, 6, 0), Quaternion.Euler(-90, 0, 0));
                }
                else if (slotNum == 3)
                {
                    Instantiate(enemy, new Vector3(3.33f, 6, 0), Quaternion.Euler(-90, 0, 0));
                }
                else if (slotNum == 4)
                {
                    Instantiate(enemy, new Vector3(6.66f, 6, 0), Quaternion.Euler(-90, 0, 0));
                }
                enemySlots[slotNum] = 1;
            }
            else
            {
                enemyCount--;
            }
        }
    }

    IEnumerator StartNextWave()
    {
        GameObject.FindGameObjectWithTag("LevelWaveText").GetComponent<UIControlScript>().NextWave();
        rowMax = 3;
        waveNumber++;
        yield return new WaitForSeconds(5);
        StopCoroutine(StartNextWave());
    }
}
