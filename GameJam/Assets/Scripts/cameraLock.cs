using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLock : MonoBehaviour
{
    public float maxDis;
    private void Update()
    {       
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit Hit;
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit, maxDis))
            {
                if (Hit.transform.GetComponentInParent<Rotate>() != null)
                {
                    Hit.transform.GetComponentInParent<Rotate>().I_Rot();
                }
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * Hit.distance, Color.yellow);
                Debug.Log(Hit.collider.name);
            }
        }
    }
}
