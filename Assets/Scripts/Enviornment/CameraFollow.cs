    using UnityEngine;
    using System.Collections;
     
    public class CameraFollow : MonoBehaviour {


    public Transform target;
    public float smoothTime = 1F;
     [SerializeField] private Vector3 offset;

    void FixedUpdate()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition = target.position+offset;

        // Smoothly move the camera towards that target position
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothTime);
    }
}
