using System.Security.Cryptography;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy01Health : MonoBehaviour
{

    public int enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = 7;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnTriggerEnter(Collider col)
{
    if (col.tag == "Bullet")
    {
        enemyHealth--;
    }
    if (col.tag == "Bullet" && enemyHealth <= 0)
    {
        Destroy(gameObject);
        AmyCharacter.score++;
    }
}

}
