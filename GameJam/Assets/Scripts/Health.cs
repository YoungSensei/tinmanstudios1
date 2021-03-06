﻿using System.Collections;
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
    AudioSource audi;
    public AudioClip dead;
    
    public GameObject DeathP;

    void Start()
    {
        health = maxHealth;
        audi = GetComponent<AudioSource>();
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
            health = 0;
            StartCoroutine("Death");
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
    IEnumerator Death()
    {
        if(!audi.isPlaying)
        audi.PlayOneShot(dead,.5f);


        GetComponent<ThirdPersonController>().enabled=false;
        GetComponentInChildren <ThirdPersonCamera>().enabled = false;
        DeathP.GetComponent<Animator>().SetBool("Died",true);
        yield return new WaitForSeconds(dead.length);
        audi.enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
