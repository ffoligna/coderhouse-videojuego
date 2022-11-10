using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnTriggerEnter(Collider col)
{
    if (col.transform.gameObject.tag == "Enemy")
    {
        Destroy(gameObject);

    }
    if (col.transform.gameObject.tag == "Wall")
    {
        Destroy(gameObject);
    }
}

}
