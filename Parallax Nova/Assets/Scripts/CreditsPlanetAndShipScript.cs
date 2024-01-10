using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsPlanetAndShipScript : MonoBehaviour
{

    public bool creditsOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Planet"))
        {
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * 10);
        }
        else if (gameObject.CompareTag("Ship"))
        {
            if (creditsOver)
            {
                transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("Planet").transform.position, 0.01f);
                if (transform.position.x > -6)
                {
                    transform.localScale = new Vector3(transform.localScale.x * 0.99f, transform.localScale.y * 0.99f, transform.localScale.z * 0.99f);
                }
            }
        }
    }
}
