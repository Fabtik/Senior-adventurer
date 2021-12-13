using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy1 : MonoBehaviour
{
    private NavMeshAgent myAgent;
    private Animator anim;
    private float distance;
    public GameObject target;

    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        distance = Vector3.Distance(target.transform.position, transform.position);
        if (distance > 10)
        {
           // myAgent.enabled = false;
            anim.SetBool("isRuning", false);
        }
        if (distance <= 10)
        {
            myAgent.enabled = true;
            anim.SetBool("isRuning", true);

            myAgent.SetDestination(target.transform.position);

        }
    }
}
