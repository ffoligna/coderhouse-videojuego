using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmyBulletShoot : MonoBehaviour
{

    public GameObject Bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(Bullet, transform.position, transform.rotation);
        }
    }
}
