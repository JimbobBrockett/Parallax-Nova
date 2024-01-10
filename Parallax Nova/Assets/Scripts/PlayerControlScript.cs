using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControlScript : MonoBehaviour
{

    public GameObject bullet;
    private int HP = 20;
    private bool dead = false;
    private float deathTimer;
    AudioSource blasterShotSound, deathSound;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource[] audios = GetComponents<AudioSource>();
        blasterShotSound = audios[0];
        deathSound = audios[1];
        deathTimer = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (!dead)
        {
            blasterShotSound.volume = SettingsScript.sfxVolume;
            deathSound.volume = SettingsScript.sfxVolume;

            PlayerMove();
            PlayerShoot();
        }
        else
        {
            deathTimer -= Time.deltaTime;
            if (deathTimer <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void PlayerMove()
    {
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
            if (transform.position.x < -10)
            {
                transform.position = new Vector3(-10, transform.position.y, transform.position.z);
            }
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
            if (transform.position.x > 10)
            {
                transform.position = new Vector3(10, transform.position.y, transform.position.z);
            }
        }
    }

    private void PlayerShoot()
    {
        if (Input.GetKeyDown("space") && SettingsScript.shootButtonNum == 0)
        {
            if (SceneManager.GetActiveScene().name != "Level3")
            {
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), new Quaternion(0, 0, 0, 0));
                blasterShotSound.Play();
            }
            else
            {
                Instantiate(bullet, new Vector3(transform.position.x + 0.1f, transform.position.y + 0.5f, transform.position.z), new Quaternion(0, 0, 0, 0));
                Instantiate(bullet, new Vector3(transform.position.x - 0.1f, transform.position.y + 0.5f, transform.position.z), new Quaternion(0, 0, 0, 0));
                blasterShotSound.Play();
            }
        }
        else if (Input.GetMouseButtonDown(0) && SettingsScript.shootButtonNum == 1)
        {
            if (SceneManager.GetActiveScene().name != "Level3")
            {
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), new Quaternion(0, 0, 0, 0));
                blasterShotSound.Play();
            }
            else
            {
                Instantiate(bullet, new Vector3(transform.position.x + 0.1f, transform.position.y + 0.5f, transform.position.z), new Quaternion(0, 0, 0, 0));
                Instantiate(bullet, new Vector3(transform.position.x - 0.1f, transform.position.y + 0.5f, transform.position.z), new Quaternion(0, 0, 0, 0));
                blasterShotSound.Play();
            }
        }
    }

    public void DamagePlayer()
    {
        HP--;
        if (HP <= 0)
        {
            if (!deathSound.isPlaying)
            {
                deathSound.Play();
            }
            dead = true;
        }
    }

    public void MassiveDamagePlayer()
    {
        HP -= 5;
        if (HP <= 0)
        {
            if (!deathSound.isPlaying)
            {
                deathSound.Play();
            }
            dead = true;
        }
    }

    public int GetHP()
    {
        return HP;
    }
}
