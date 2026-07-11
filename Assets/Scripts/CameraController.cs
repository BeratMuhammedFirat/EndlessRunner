using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform hedef;
    public Vector3 mesafe=Vector3.zero;

    private float fixedX= -322.173f;
    private void Awake()
    {
        mesafe = transform.position-hedef.position;
    }
    void LateUpdate()
    {
        Vector3 pos = hedef.position + mesafe;
        pos.x = fixedX;
        transform.position = pos;

    }
}
