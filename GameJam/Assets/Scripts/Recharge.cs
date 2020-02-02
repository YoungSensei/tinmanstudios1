using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recharge : MonoBehaviour
{
    public AudioClip charging;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            other.GetComponent<Health>().isCharging = true;
            if (!GetComponent<AudioSource>().isPlaying)
                GetComponent<AudioSource>().PlayOneShot(charging, .05f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<Health>().isCharging = false;

            gameObject.GetComponent<AudioSource>().Stop();
        }
        
    }
}
