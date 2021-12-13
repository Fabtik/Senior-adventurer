using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelthbarController : MonoBehaviour
{
    public Image healthBar;
    public float health;
    public float startHealth;
    public GameObject DethScreen;
    


    void Start()
    {

        DethScreen.SetActive(false);
    }

    public void OnTakeDamage(int damage)
    {
        health = health - damage;
        healthBar.fillAmount = health / startHealth;
        if(health <= 0)
        {
            DethScreen.SetActive(true);
            //Time.timeScale = 0f;
        }
    }

    public float HP()
    {
        return health;
    }
}

