using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public Vector3 force;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void active()
    {
        Debug.Log(bullet.name + "Activete!");
        bullet.GetComponent<Rigidbody>().AddForce(force);
    }
}
