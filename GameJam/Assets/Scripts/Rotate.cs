using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int rot;

    public void I_Rot()
    {
        gameObject.GetComponentInChildren<Transform>().transform.Rotate(0, rot, 0);
    }
}
