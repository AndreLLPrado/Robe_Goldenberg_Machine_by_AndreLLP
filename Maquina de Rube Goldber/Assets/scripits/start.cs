using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 force;
    public bool startMachine;
    void Start()
    {
        //force.Set(0, 0, 0);
        startMachine = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && startMachine == true)
        {
            GetComponent<Rigidbody>().AddForce(force);
            startMachine = false;
        }
    }
}
