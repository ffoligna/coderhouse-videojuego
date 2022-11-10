using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy01Script : MonoBehaviour
{

    public GameObject Amy;
    public float lookSpeed = 0.3f;
    Vector3 enemy01Chase;
    public float chaseSpeed = 0.02f;
    public float attackSpeed = 0.2f;
    
    public Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        Amy = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        LookAtAmy();
        AmyChase();
        noRespawn();
    }

void LookAtAmy()
{
    Quaternion rot = Quaternion.LookRotation(Amy.transform.position - transform.position);
    transform.rotation = rot;

    Quaternion.Lerp(transform.rotation, rot, lookSpeed * Time.deltaTime);
}

void AmyChase()
{
    transform.position = Vector3.Lerp(transform.position, Amy.transform.position, chaseSpeed * Time.deltaTime);

    float dist = Vector3.Distance(transform.position, Amy.transform.position);
    if (dist > 1 && enemy01Chase == Vector3.zero)
    {
        chaseSpeed = 0;
        anim.SetBool("ZombieWalk", false);
    }
    
    if (dist < 15 && dist > 1.1f)
    {
        chaseSpeed = 0.8f;
        anim.SetBool("ZombieWalk", true);
    }
    
    if (dist < 2)
    {
        attackSpeed = 0.6f;
        anim.SetBool("ZombieAttack", true);
    }

    else
    {
        anim.SetBool("ZombieAttack", false);
    }
}

void noRespawn()
{
  if (transform.position.y < -5)
  {
    Destroy(gameObject);
  }
}

}
