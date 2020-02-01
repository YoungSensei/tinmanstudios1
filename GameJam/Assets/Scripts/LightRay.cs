using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRay : MonoBehaviour
{
    GameObject LightPos;
    // Start is called before the first frame update
    void Start()
    {
        LightPos = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(LightPos.transform.position,LightPos.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.transform.name == "LightTriggerSpace")
            {
                Debug.DrawLine(LightPos.transform.position, hit.point, Color.yellow);
            }
        }
    }
}
