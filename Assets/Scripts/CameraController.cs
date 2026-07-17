using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform hedef;
    public Vector3 mesafe;

    public float smoothSpeed = 10f;

    //private float fixedX = -322.173f;

    private void Awake()
    {
        mesafe = transform.position - hedef.position;
    }

    void LateUpdate()
    {
        Vector3 targetPosition = hedef.position + mesafe;
       // targetPosition.x = fixedX;

        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            smoothSpeed * Time.deltaTime
        );
    }
}