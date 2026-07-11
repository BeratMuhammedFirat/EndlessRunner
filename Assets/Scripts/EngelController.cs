using UnityEngine;

public class EngelController : MonoBehaviour

{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Çarptı");
            collision.gameObject.GetComponent<HealtManager>().TakeDamage();

        }
    }

   
}
