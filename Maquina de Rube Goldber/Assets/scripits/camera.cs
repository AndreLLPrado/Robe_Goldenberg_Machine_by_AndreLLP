using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    public float vel;
    float rotX, rotY;

    public GameObject cameraFPS;
    void Start()
    {
        cameraFPS.transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f,  0.0f, 1 * vel);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, 0.0f, -1 * vel);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * vel, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(1 * vel, 0.0f, 0.0f);
        }

        FPSCam();
    }

    void FPSCam()
    {
        rotX += Input.GetAxis("Mouse X") * 5.0f;
        rotY += Input.GetAxis("Mouse Y") * 5.0f;

        rotX = ClampAngleFPS(rotX, -360, 360);
        rotY = ClampAngleFPS(rotY, -80, 80);

        Quaternion xQuaternion = Quaternion.AngleAxis(rotX, Vector3.up);
        Quaternion yQuaternion = Quaternion.AngleAxis(rotY, -Vector3.right);
        Quaternion finalRotate = Quaternion.identity * xQuaternion * yQuaternion;

        cameraFPS.transform.rotation = Quaternion.Lerp(cameraFPS.transform.rotation, finalRotate, Time.deltaTime * 10.0f);

    }

    float ClampAngleFPS(float angle, float min, float max)
    {
        if (angle < -360)
        {
            angle += 360;
        }

        if (angle > 360)
        {
            angle -= 360;
        }
        return Mathf.Clamp(angle, min, max);
    }
}
