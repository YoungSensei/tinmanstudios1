using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public bool PlayerIsHere = false;
    public bool ButtonPressed = false;

    public Material Bad;
    public Material Good;

    public GameObject WaterTank;
    public void Update()
    {
        if(ButtonPressed == true)
        {
            WaterTank.GetComponent<Renderer>().material.color = Good.color;
        }
        else
        {
            WaterTank.GetComponent<Renderer>().material.color = Bad.color;
        }
        if(PlayerIsHere == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                ButtonPressed = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            PlayerIsHere = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            PlayerIsHere = false;
        }
    }
}
