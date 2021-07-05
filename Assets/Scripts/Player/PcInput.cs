using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcInput : MonoBehaviour
{
    float h, v;
    [SerializeField] VectorSO Movement;

   

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal") ;
        v = Input.GetAxis("Vertical") ;
        Movement.value.x = h;
        Movement.value.y = 0;
        Movement.value.z = v;
    }
}
