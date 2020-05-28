using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objActivate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "button")
        {
            Debug.Log(collision.gameObject.name + " Activate!");
            objActivate.GetComponent<bulletShoot>().active();
        }

        if(collision.gameObject.tag == "test")
        {
            Debug.Log("Collision Detected!");
        }
    }
}
