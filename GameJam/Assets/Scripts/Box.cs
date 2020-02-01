using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public bool PowerOn;
    GameObject gm;

    private void Start()
    {
        PowerOn = false;
        gm = GameObject.Find("GameManager");
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Box")
        {
            other.GetComponent<Renderer>().material.color = Color.blue;
            gm.GetComponent<GameManager>().powerLevel++;
            PowerOn = true;
        }
    }
}
