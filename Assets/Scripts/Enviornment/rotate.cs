using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
  
    private bool forward = true;
    private int random;
    private float xangle = 0, yangle = 0, zangle = 0;
    private bool isAroundYAxis = false;
    float angletoCheck;
    private void Start()
    {
        random = Random.Range(1, 4);
        if (random == 1)
            xangle = Random.Range(0.05f, 0.1f);
        else if (random == 2)
        { yangle = Random.Range(0.05f, 0.1f); isAroundYAxis = true; }
        else if (random == 3)
            zangle = Random.Range(0.05f, 0.1f);

    }
    void Update()
    {
       
        switch (random)
        {
            case 1:
                angletoCheck = transform.rotation.eulerAngles.x;
                break;
            case 2:
                angletoCheck = transform.rotation.eulerAngles.y;
                break;
            case 3:
                angletoCheck = transform.rotation.eulerAngles.z;
                break;
        }
        if (forward|| isAroundYAxis)
        {
            
            transform.Rotate(xangle, yangle, zangle);

            if (angletoCheck >= 19 && angletoCheck <= 339)
            {

                xangle = -xangle;
              
                zangle = -zangle;
                forward = false;
            }
        }
        else
        {
            transform.Rotate(xangle, yangle, zangle);
            if (angletoCheck > 20 && angletoCheck < 340)
            {
              
                xangle = -xangle;
                
                zangle = -zangle;
                 forward = true;
            }


        }

    }


}
