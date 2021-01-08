    using UnityEngine;
    using System.Collections;
     
    public class CameraFollow : MonoBehaviour {


    public Transform target;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
     [SerializeField] private Vector3 offset;

    void LateUpdate()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition = target.position+offset;

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime*Time.deltaTime);
    }
}
