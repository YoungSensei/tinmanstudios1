using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRay : MonoBehaviour
{
    GameObject LightPos;
    //public int MaxReflect;
    public int CurRef = 0;
    //public float maxDis;
    List<GameObject> MirrorHit = new List<GameObject>();
    //bool firstMirror = true;
    private Vector3 dir;
    //LineRenderer LaserPointer;

    // Start is called before the first frame update
    void Awake()
    {
       
        LightPos = transform.GetChild(0).gameObject;
        if (LightPos.name == "LightRayPos")
        {
            Debug.Log("Worked");
        }
        //LaserPointer = transform.GetChild(1).GetComponent<LineRenderer>();
        //if(LaserPointer.name == "LightLine")
        //{
        //    Debug.Log("LineRenderer found");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //LaserPointer.SetPosition(0, LightPos.transform.position);
        RaycastHit Hit;
        if (Physics.Raycast(LightPos.transform.position, LightPos.transform.forward, out Hit, Mathf.Infinity))
        {           
            Debug.DrawRay(LightPos.transform.position, transform.TransformDirection(Vector3.forward) * Hit.distance, Color.red);
            if (Hit.collider.name == "LightTriggerSpace")
            {
                //LaserPointer.SetPosition(1, Hit.point);
                GameObject MirPar = Hit.collider.gameObject;
                if (MirPar != null)
                {
                    Bubble(MirPar, Hit);
                }
            }
            else if(Hit.collider.GetComponent<ButRay>() != null)
            {
                Hit.collider.GetComponent<ButRay>().Activated();
            }
        }
    }

    public void Bubble(GameObject Bounce, RaycastHit Info)
    {

        if (!MirrorHit.Contains(Bounce))
        {
            Debug.Log(Bounce);
            MirrorHit.Add(Bounce);
        }
        else if (MirrorHit.Contains(Bounce))
        {
            RaycastHit Rich;
            if (Physics.Raycast(Bounce.transform.position, Bounce.transform.forward, out Rich, Mathf.Infinity))
            {
                Debug.DrawRay(Bounce.transform.position, Bounce.transform.TransformDirection(Vector3.forward) * Rich.distance, Color.yellow);
                if (Rich.collider.name == "LightTriggerSpace")
                {
                    //LaserPointer.SetPosition(2, Rich.point);
                    GameObject Recast = Rich.collider.gameObject;
                    if (Recast != null)
                    {
                        Bubble(Recast, Rich);
                    }
                }
                else if (Rich.collider.GetComponent<ButRay>() != null)
                {
                    Rich.collider.GetComponent<ButRay>().Activated();
                }                
            }
        }
    }
}

