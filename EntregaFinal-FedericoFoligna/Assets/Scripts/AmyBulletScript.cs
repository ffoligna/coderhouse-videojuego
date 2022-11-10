using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmyBulletScript : MonoBehaviour
{
    public float BulletSpeed;
    public GameObject GunBulletPosition;
    RaycastHit EnemyHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(transform.forward * BulletSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * BulletSpeed * Time.deltaTime);

        // if (Input.GetKeyDown("space"))
        // {
        //         if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out EnemyHit, 7.6f))
        //     {
        //         Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * EnemyHit.distance, Color.red);
        //     }
        // }
    }
}
