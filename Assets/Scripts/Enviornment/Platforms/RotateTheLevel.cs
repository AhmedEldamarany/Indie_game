using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTheLevel : MonoBehaviour
{
    Vector3 tilt;
    [SerializeField] float rotSpeed=.5f;
    Quaternion desiredRotation;
    void Start()
    {
        desiredRotation = Quaternion.identity;
    }

    void Update()
    {
        tilt = Input.acceleration;
        {  //works fine but not smooth
            //Debug.Log(Input.acceleration);
           // desiredRotation.z =  (tilt.x * -rotSpeed);
           //transform.rotation = desiredRotation;
        }
        transform.Rotate(0, 0, tilt.x*-rotSpeed); //.5
    }
}
