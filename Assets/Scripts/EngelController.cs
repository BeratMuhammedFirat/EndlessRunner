using UnityEngine;

public class EngelController : MonoBehaviour

{
    public BoxCollider collieder;

    private void Start()
    {
        collieder = GetComponent<BoxCollider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<HealtManager>().TakeDamage();
            collieder.isTrigger = true;

        }
    }

   
}
