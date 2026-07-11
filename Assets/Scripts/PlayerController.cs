using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15f;

    private float[] lanes = { -324.96f, -322.03f, -318.94f };
    private int currentLane = 1; // 0 = Sol, 1 = Orta, 2 = Sağ

    void Update()
    {
        // Sürekli ileri hareket
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Sola geç
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentLane--;
            currentLane = Mathf.Clamp(currentLane, 0, 2);
        }

        // Sağa geç
        if (Input.GetKeyDown(KeyCode.D))
        {
            currentLane++;
            currentLane = Mathf.Clamp(currentLane, 0, 2);
        }

        // Karakteri bulunduğu şeride yerleştir
        Vector3 pos = transform.position;
        pos.x = lanes[currentLane];
        transform.position = pos;
    }
}