using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{

    private Animator anim;
    public HelthbarController helthbar;
    public StaminaController stamina;
   // private float timeBtwAttack;
   //public float startTimeBtwAttack;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
  
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isRunning", true);
        }
        else anim.SetBool("isRunning", false);
        if (helthbar.HP() <= 0f)
        {
            anim.SetBool("isDead", true);

        }

        //if (timeBtwAttack <= 0)
        //{
        //  if (Input.GetMouseButton(0))
        //  {
        //       anim.SetTrigger("attack");
        //  }

        // timeBtwAttack = startTimeBtwAttack;
        //}
        // else
        // {
        //     timeBtwAttack -= Time.deltaTime;
        // }

        if (Input.GetMouseButton(0) && stamina.ST() >= 1)
        {
            anim.SetTrigger("attack");
            stamina.staminaSpending(1);
        }

    }
}
