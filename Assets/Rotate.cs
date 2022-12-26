using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed_fan = 200.0f;
    public Transform rotate;

    void Start()
    {
    }

    void Update()
    {
        rotate.Rotate(Vector3.forward * speed_fan * Time.deltaTime);
        //rotate.Translate(Vector3.forward * speed_fan * Time.deltaTime);
    }
}
