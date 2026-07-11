using UnityEngine;

public class CoınManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger çalıştı");
            other.gameObject.GetComponent<ScoreManager>().scoreArtir();
            Destroy(gameObject);

        }
    }
}
