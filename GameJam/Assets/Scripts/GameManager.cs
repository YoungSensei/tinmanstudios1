using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int powerLevel;
    public GameObject bright;
    // Start is called before the first frame update
    void Start()
    {
        powerLevel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        switch (powerLevel)
        {
            case 0:
                bright.GetComponent<Light>().intensity = 0f;
                break;

            case 1:
                bright.GetComponent<Light>().intensity = .5f;
                break;

            case 2:
                bright.GetComponent<Light>().intensity = 1f;
                break;

            case 3:
                bright.GetComponent<Light>().intensity = 1.5f;
                break;

            case 4:
                bright.GetComponent<Light>().intensity = 2f;
                break;
        }
    }
}
