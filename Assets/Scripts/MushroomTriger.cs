using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomTriger : MonoBehaviour
{
    public Animator anim;
    public bool aboba = false;

    // Start is called before the first frame update
    void Start()
    {
       // anim = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            aboba = true;
            anim.SetBool("isPlayer", true);
            
        }

    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("isPlayer", false);
        }
    }
}
