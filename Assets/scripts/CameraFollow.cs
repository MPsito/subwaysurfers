using UnityEngine;

public class CameraFollow : MonoBehaviour
{
[SerializeField]
private Transform target;
[SerializeField]
private float smoothSpeed = 0.125f;
private Vector3 offset;
private void Start()
    {
        Vector3 initialPosition = transform.position;
        offset = initialPosition - target.position;
    }
 private void LateUpdate() 
    {
        Vector3 desiredposition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredposition, smoothSpeed);
        transform.position= smoothedPosition;
    }
}
