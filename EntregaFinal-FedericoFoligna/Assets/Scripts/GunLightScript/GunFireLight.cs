using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFireLight : MonoBehaviour
{
    Light lightFire;

    // Start is called before the first frame update
    void Start()
    {
        lightFire = GetComponent<Light>();
        lightFire.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine ("TimeLight");
        }
        
    }

IEnumerator TimeLight()
{
    lightFire.enabled = true;
    yield return new WaitForSeconds (0.1f);
    lightFire.enabled = false;
}

}
