using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fire : MonoBehaviour
{
    public HelthbarController helthbar;
    public GameObject PlayerParticle;
    

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            PlayerParticle.SetActive(true);
            helthbar.OnTakeDamage(1);
            
        }
        
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            StartCoroutine (AfterFire() );
        }

    }

    
    IEnumerator AfterFire()
    {
        for (int i = 0; i < 15; i++)
        {
            yield return new WaitForSeconds(0.1f);
            helthbar.OnTakeDamage(1);
        }
        PlayerParticle.SetActive(false);
    }
}
