using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject active;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "button")
        {
            Debug.Log(collision.gameObject.name + " Activate!");

            //collision.gameObject.GetComponent<bulletShoot>().active();
            active.GetComponent<bulletShoot>().active();
        }
    }
}
