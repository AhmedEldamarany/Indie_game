using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandPoolObject : PoolItem
{
    public override void Activate()
    {
        gameObject.SetActive(true);
    }

    public override void Deactivate()
    {
        gameObject.SetActive(false);
    }

  
}
