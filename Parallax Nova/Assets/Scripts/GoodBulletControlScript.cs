using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodBulletControlScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletMove();
        CheckIfVisible();
    }

    private void BulletMove()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f, transform.position.z);
    }

    private void CheckIfVisible()
    {
        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyControlScript>().DamageEnemy();
            Destroy(gameObject);
        }
    }
}
