using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeConditional : MonoBehaviour
{
    public float speed_con = 20.0f;
    public Transform rotate;
    private Quaternion startLocation;

    void Start()
    {
        startLocation = transform.rotation;
    }

    void Update()
    {
       if (Quaternion.Angle(startLocation, transform.rotation) >= 30)
            speed_con = -speed_con;
        rotate.Rotate(Vector3.forward * speed_con * Time.deltaTime);   
    }
}
