using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScripit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = false;
        GameObject.Find("Main Camera").GetComponent<camera>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activeCanvas()
    {
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = true;
        GameObject.Find("Main Camera").GetComponent<camera>().enabled = false;
    }
}
