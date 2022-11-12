using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AmyCharacter : MonoBehaviour
{
    float horizontal;
    float vertical;
    Vector3 playerMovement;
    Vector3 initialPosition;
    public float speed = 5f;
    public float speedRotation = 80f;
    public Animator anim;
    public GameObject cameraOne;
    public GameObject cameraTwo;
    public static float health = 100f;
    public static int score = 0;
    float time = 1f;


    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        cameraOne.SetActive(false);
        health = 100f;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        playerMovement = new Vector3 (horizontal, 0, vertical);
        transform.Translate(playerMovement * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate (0, -1 * speedRotation * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate (0, 1 * speedRotation * Time.deltaTime, 0);
        }

        amyRun();
        amyShoot();
        respawn();
        amyCameras();
        attackCooldown();

    }

void respawn()
{
  if (transform.position.y < -5)
  {
    transform.position = initialPosition;
  }
}

void amyRun()
{
    if (playerMovement == Vector3.zero)
    {
        anim.SetBool("AmyGunplayRun", false);
    }
    else
    {
        anim.SetBool("AmyGunplayRun", true);
    }
}

void amyShoot()
{
    if (Input.GetKey(KeyCode.Space))
    {
        anim.SetBool("AmyShooting", true);
    }
    else
    {
        anim.SetBool("AmyShooting", false);
    }
}

void amyCameras()
{
    if (Input.GetKeyDown(KeyCode.C))
    {
        activateDeactivateCam();
    }
}

void activateDeactivateCam()
{
    if (cameraOne.activeInHierarchy)
    {
        cameraOne.SetActive(false);
        cameraTwo.SetActive(true);
    }

    else if (cameraTwo.activeInHierarchy)
    {
        cameraOne.SetActive(true);
        cameraTwo.SetActive(false);
    }
}


void OnTriggerStay (Collider other)
{
    if (other.gameObject.tag == "Enemy" && time <= 0)
    {
        health -= Random.Range(6,8);
    }
}

void attackCooldown()
{
    if (time <= 0)
    {
        time = 1f;
    }
    else
    {
        time -= Time.deltaTime;
    }
}



}
