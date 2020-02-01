using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButRay : MonoBehaviour
{
    public void Activated()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
}
