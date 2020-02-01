using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float maxHealth = 100;
    public float health=100;
    public Image healthbar;
    public float drain=1;
    public float charge = 1;
    public bool isCharging;
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCharging == true)
        {
            Charge();
        }
        else
        {
        Drain();
        }
    }
    void Drain()
    {
        health -= drain* Time.deltaTime;
        healthbar.fillAmount = health / maxHealth;
        if(health <= 0)
        {
            Death();
        }
    }
    void Charge()
    {
        health += charge * Time.deltaTime;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        healthbar.fillAmount = health / maxHealth;
    }
    void Death()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
