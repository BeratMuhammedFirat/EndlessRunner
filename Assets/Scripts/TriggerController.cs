using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public GameManager manager;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Oyun Sonu");
        manager.GameOver();
        
    }
}
