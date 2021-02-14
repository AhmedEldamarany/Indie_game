using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadPoolObject : PoolItem //mine
    {
    [SerializeField] private DifficultySO diffuclty;
    public override void Activate()
    {
        gameObject.SetActive(true);
        switch (diffuclty.value) 
        {
            case DifficultySO.Diffuclty.meduim:
                GetComponent<rotate>().enabled = true;
                break;
            case  DifficultySO.Diffuclty.hard:
                GetComponent<move>().enabled = true;
                break;
            case DifficultySO.Diffuclty.insane:
                GetComponent<rotate>().enabled = true;
                GetComponent<move>().enabled = true;
                break;
        }
    }

    public override void Deactivate()
    {
        GetComponent<rotate>().enabled = false; //resiting
        transform.rotation = Quaternion.Euler(0, -90, 0); // every
        GetComponent<move>().enabled = false; //road chunk
        gameObject.SetActive(false);
    }

}
