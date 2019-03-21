using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {

            GameObject b = Instantiate(bullet, transform.position + transform.up * 1.5f, Quaternion.identity);

            b.GetComponent<Rigidbody2D>().AddForce(transform.up * 3000);

        }
    }
}
