    using UnityEngine;
    using System.Collections;
     
    public class flying : MonoBehaviour {

 
     Transform player;
    Vector3 offset;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        offset = player.position - this.transform.position;
    }
    void Update () {
        this.transform.position = player.position-offset;
                       
        }
         
      
    }
