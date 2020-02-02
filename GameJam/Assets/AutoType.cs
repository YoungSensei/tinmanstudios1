using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class AutoType : MonoBehaviour
{
    string dead = "Shutting Down...";

    private void Start()
    {
        StartCoroutine("Type");
    }
    IEnumerator Type()
    {
        foreach (char letters in dead.ToCharArray())
        {
            GetComponent<Text>().text += letters;
            yield return new WaitForSeconds(0.3f);
        }
        
    }
}
