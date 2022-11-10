using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy01Instantiate : MonoBehaviour
{
    public GameObject Enemy01;
    public GameObject Enemy02;
    public GameObject Enemy03;
    public GameObject VictoryScreen;
    public GameObject DefeatScreen;
    public GameObject HudMenu;
    bool isEnd;
    int enemyCount;
    public int enemiesNumber;


    // Start is called before the first frame update
    void Start()
    {
        for (int a = 15; a > 0; --a)
        {
            float x = Random.Range(20f,-20f);
            float y = -0.9379983f;
            float z = Random.Range(20f,-20f);
            Instantiate(Enemy01, new Vector3(x,y,z), Quaternion.identity);
        }

        StartCoroutine(SecondWave(10));
        StartCoroutine(ThirdWave(25));
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = enemiesNumber - 1;
        enemiesNumber = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (enemiesNumber == 0 && isEnd == false)
        {
            VictoryScreen.SetActive(true);
            HudMenu.SetActive(false);
            Time.timeScale = 0;
        }

        if (AmyCharacter.health <= 0)
        {
            DefeatScreen.SetActive(true);
            HudMenu.SetActive(false);
            Time.timeScale = 0;
        }
    }

    IEnumerator SecondWave(float time)
    {
        yield return new WaitForSeconds(time);

        for (int a = 12; a > 0; --a)
        {
            float x = Random.Range(20f,-20f);
            float y = -0.9379983f;
            float z = Random.Range(20f,-20f);
            Instantiate(Enemy02, new Vector3(x,y,z), Quaternion.identity);
        }
    }

    IEnumerator ThirdWave(float time)
    {
        yield return new WaitForSeconds(time);

        for (int a = 10; a > 0; --a)
        {
            float x = Random.Range(20f,-20f);
            float y = -0.9379983f;
            float z = Random.Range(20f,-20f);
            Instantiate(Enemy03, new Vector3(x,y,z), Quaternion.identity);
        }
    }
}
