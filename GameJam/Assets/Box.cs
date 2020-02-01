using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public bool PowerOn;

    private void Start()
    {
        PowerOn = false; 
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Box")
        {
            other.GetComponent<Renderer>().material.color = Color.blue;
            
            PowerOn = true;
        }
    }
}
