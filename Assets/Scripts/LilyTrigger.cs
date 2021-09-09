using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilyTrigger : MonoBehaviour
{
    public Animator anim;

    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
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
