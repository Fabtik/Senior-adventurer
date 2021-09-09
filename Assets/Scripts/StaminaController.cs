using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaController : MonoBehaviour
{
    public Image staminaBar;
    public float stamina;
    public float startStamina;
   




    public void staminaSpending(int spending)
    {
        stamina = stamina - spending;
        staminaBar.fillAmount = stamina / startStamina;
        
    }

    public float ST()
    {
        return stamina;
    }

    


    void FixedUpdate()
    {
        if (stamina <= 1)
        {
            stamina += 0.005f;
        }
        staminaBar.fillAmount = stamina / startStamina;
    }
}