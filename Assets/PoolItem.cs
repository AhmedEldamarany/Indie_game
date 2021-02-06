using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class PoolItem:MonoBehaviour
{ 
    abstract public void Activate();
    abstract public void Deactivate();
}
