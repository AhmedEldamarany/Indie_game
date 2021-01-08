using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private bool moveAhead = true;
    private int random;
    public float movingSpeed;

    void Start()
    {
        random = Random.Range(1, 3);
        movingSpeed = .01f;

    }

    void Update()
    {
        if (random == 1)
        {
            if (moveAhead)
            {
                transform.Translate(movingSpeed, 0, 0,Space.World);
                if (transform.position.x > 5)
                    moveAhead = false;
            }
            else
            {

                transform.Translate(-movingSpeed, 0, 0,Space.World);
                if (transform.position.x < -5)
                    moveAhead = true;
            }
        }
        else if (random == 2)
        {
            if (moveAhead)
            {
                transform.Translate(0, movingSpeed, 0,Space.World);
                if (transform.position.y > 5)
                    moveAhead = false;
            }
            else
            {

                transform.Translate(0, -movingSpeed, 0,Space.World);
                if (transform.position.y < -5)
                    moveAhead = true;
            }
        }
    }
}
