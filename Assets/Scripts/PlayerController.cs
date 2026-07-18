using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15f;

    private float[] lanes = { -324.96f, -322.03f, -318.94f };
    private int currentLane = 1; // 0 = Sol, 1 = Orta, 2 = Sağ

    public Rigidbody rb;
    private bool isGrounded = true;

    public float jumpForce = 5f;

    public float slideDuration = 0.5f;
    private bool isSliding = false;
    private Vector3 normalScale;



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        normalScale = transform.localScale;

    }

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
        Vector3 targetPosition = transform.position;
        targetPosition.x = lanes[currentLane];

        transform.position = Vector3.Lerp(transform.position,targetPosition,10f * Time.deltaTime);



        if (Input.GetKeyDown(KeyCode.Space) && isGrounded )
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        if (transform.position.y <= 70.54f)
        {
            isGrounded = true;
        }

        if (Input.GetKeyDown(KeyCode.S) && !isSliding)
        {
            StartCoroutine(Slide());
        }       
    }
    IEnumerator Slide()
    {
        isSliding = true;

        // Küçült
        transform.localScale = new Vector3(
            normalScale.x,
            normalScale.y / 2f,
            normalScale.z);

        yield return new WaitForSeconds(slideDuration);

        // Eski haline getir
        transform.localScale = normalScale;

        isSliding = false;
    }

    /*public void HizArtir ()
    {
        speed += 3f;
    }*/
}