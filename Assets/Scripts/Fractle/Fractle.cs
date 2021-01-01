using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fractle : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 position;
    public GameObject Object;
    public int iterations;
    Vector3 newPosition;
    void Start()
    {
        position = Vector3.zero;
        CreateACube(position, 10, iterations,this.transform.gameObject);

    }

    void CreateACube(Vector3 position, float scale, int i,GameObject parent)
    {
        if (i == 0) return;
      
        GameObject newCube = Instantiate<GameObject>(Object, position, Object.transform.rotation);
        newCube.transform.localScale = new Vector3(scale, scale, scale);
        newCube.transform.SetParent(parent.transform);
        //Recursion
        //Z axis
        newPosition = position + (Vector3.forward * (scale / 2f + scale / 4f));
        CreateACube(newPosition, (scale / 2f), i - 1,newCube);
        newPosition = position + (Vector3.back * (scale / 2f + scale / 4f));
        CreateACube(newPosition, (scale / 2f), i - 1,newCube);
        //X axis
        newPosition = position + (Vector3.right * (scale / 2f + scale / 4f));
        CreateACube(newPosition, (scale / 2f), i - 1,newCube);
        newPosition = position + (Vector3.left * (scale / 2f + scale / 4f));
        CreateACube(newPosition, (scale / 2f), i - 1,newCube);
        //Y axis
        newPosition = position + (Vector3.up * (scale / 2f + scale / 4f));
        CreateACube(newPosition, (scale / 2f), i - 1,newCube);
        newPosition = position + (Vector3.down * (scale / 2f + scale / 4f));
        CreateACube(newPosition, (scale / 2f), i - 1,newCube);

    }

}
