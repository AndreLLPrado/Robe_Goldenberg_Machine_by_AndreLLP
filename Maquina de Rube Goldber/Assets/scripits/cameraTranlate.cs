using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTranlate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] positions;
    int nPositions;
    public Vector3 vel;
    int e = 0;

    void Start()
    {
        nPositions = positions.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != positions[e].transform.position && e <= nPositions)
        {
            transform.Translate((transform.position += positions[e].transform.position) * Time.deltaTime);
        }
        else
        {
            e++;
        }
    }
}
