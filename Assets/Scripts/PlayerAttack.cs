using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack = 1;
    public Animator anim;
    //public StaminaController stamina;

     void OnTriggerStay(Collider collider)
     {
        if (timeBtwAttack <= 0)
        {
            // if (Input.GetMouseButton(0))
            // {
                 
                 if (collider.gameObject.tag == "PlayerAttack")
                 {
                     var position = transform.position - collider.gameObject.transform.position;
                    GetComponent<Rigidbody>().AddForce(new Vector3(position.x, 0.5f, position.z) * 1f, ForceMode.Impulse);
                }

                 timeBtwAttack = startTimeBtwAttack;
             //}
        }
         else
         {
             timeBtwAttack -= 1;
         }
     }

   /* void OnTriggerStay(Collider collider)
    {
            if (Input.GetMouseButton(0))
            {
                if (collider.gameObject.tag == "Player")
                {
                    var position = transform.position - collider.gameObject.transform.position;
                //GetComponent<Rigidbody>().AddForce(new Vector3(position.x, Mathf.Abs(position.y), position.z) * 1f, ForceMode.Impulse);
                GetComponent<Rigidbody>().AddForce(new Vector3(position.x, 0.5f, position.z) * 1f, ForceMode.Impulse);
                }
            }    
    }*/




}
