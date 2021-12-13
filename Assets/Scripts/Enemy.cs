using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    /* public int helth;

     public void TakeDamage(int damage)
     {
         helth -= damage;
     }
    */
    private NavMeshAgent Agent;
    private Animator anim;
    private float distance;
    public Transform target;

    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        distance = Vector3.Distance(target.position, transform.position);  
        if(distance > 10)
        {
            Agent.enabled = false;
          //  anim.SetBool("isRuning", false);
        }
       if (distance <= 10)
        {
            Agent.enabled = true;
        //  anim.SetBool("isRuning", true);
    
            Agent.SetDestination(target.position);
        
        }
    
    }

}
