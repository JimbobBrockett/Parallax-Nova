using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControlScript : MonoBehaviour
{

    public GameObject bullet;
    private int HP = 20;
    private bool dead = false;
    private float deathTimer;
    AudioSource blasterShotSound, deathSound;
    private float movementSpeed = 5.0f;
    private float edgeClampValue = 8.0f;
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
        float horizontalInput = Input.GetAxis("Horizontal"); // Get input in the range [-1, 1]
        Vector3 movement = new Vector3(horizontalInput, 0, 0);

        transform.position += movement * movementSpeed * Time.deltaTime;

        // Limit movement within certain boundaries
        float clampedX = Mathf.Clamp(transform.position.x, -edgeClampValue, edgeClampValue);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }

    private void PlayerShoot()
    {
        if ((Input.GetKeyDown("space") && SettingsScript.shootButtonNum == 0) ||
        (Input.GetMouseButtonDown(0) && SettingsScript.shootButtonNum == 1))
        {
            Vector3 bulletSpawnPosition = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
            if (SceneManager.GetActiveScene().name != "Level3")
            {
                Instantiate(bullet, bulletSpawnPosition, Quaternion.Euler(90f, 0f, 0f));
            }
            else
            {
                Instantiate(bullet, bulletSpawnPosition + new Vector3(0.2f, 0, 0), Quaternion.Euler(90f, 0f, 0f));
                Instantiate(bullet, bulletSpawnPosition - new Vector3(0.2f, 0, 0), Quaternion.Euler(90f, 0f, 0f));
            }
            blasterShotSound.Play();
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
