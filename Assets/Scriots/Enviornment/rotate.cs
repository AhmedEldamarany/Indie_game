using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
  
    private bool forward = true;
    private int random;
    private float xangle = 0, yangle = 0, zangle = 0;
    float angletoCheck;
    private void Start()
    {
        random = 1; //Random.Range(1, 4);
        if (random == 1)
            xangle = Random.Range(0.05f, 0.1f);
        else if (random == 2)
            yangle = Random.Range(0.05f, 0.1f);
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
        if (forward)
        {
            transform.Rotate(xangle, yangle, zangle);

            if (angletoCheck >= 29 && angletoCheck <= 331)
            {
                Debug.Log(xangle);
                xangle = -xangle;
                yangle = -yangle;
                zangle = -zangle;
                forward = false;
            }
        }
        else
        {
            transform.Rotate(xangle, yangle, zangle);
            if (angletoCheck > 30 && angletoCheck < 331)
            {
                Debug.Log(xangle);
                xangle = -xangle;
                yangle = -yangle;
                zangle = -zangle;
                 forward = true;
            }


        }

    }


}
