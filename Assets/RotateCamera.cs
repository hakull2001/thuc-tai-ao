using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float speed_camera = 50.0f;
    public Transform rotate;
    private Quaternion startLocation;

    void Start()
    {
        startLocation = transform.rotation;
    }

    void Update()
    {
        if (Quaternion.Angle(startLocation, transform.rotation) >= 90)
            speed_camera = -speed_camera;
        rotate.Rotate(Vector3.forward * speed_camera * Time.deltaTime);
    }
}
