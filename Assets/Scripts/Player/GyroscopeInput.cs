using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeInput : MonoBehaviour
{
    [SerializeField]VectorSO Movement;
    private Vector3 tilt;

    // Update is called once per frame
    void Update()
    {
        tilt = Input.acceleration; //already clamped from -1 to 1
        tilt = Quaternion.Euler(135, 0, 0) * tilt ;
        tilt.y = 0;
        Movement.value = tilt;
    }
  
}
