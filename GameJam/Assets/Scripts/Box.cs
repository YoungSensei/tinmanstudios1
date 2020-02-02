using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject PowerOn;
    GameObject gm;

    private void Start()
    {
        
        gm = GameObject.Find("GameManager");
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Box")
        {
            other.GetComponent<Renderer>().material.color = Color.red;
            gm.GetComponent<GameManager>().powerLevel++;
            if(PowerOn == null)
            {
                return;
            }
            else
            {
                PowerOn.GetComponent<Animator>().SetBool("Power", true);
            }
            
        }
    }
}
