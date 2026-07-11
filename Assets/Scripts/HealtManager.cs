using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealtManager : MonoBehaviour
{
 
   
    public Image[] hearts;
    private MeshRenderer meshRenderer;
    private BoxCollider collider;
    public int health = 3;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        collider = GetComponent<BoxCollider>();
    }

    public void TakeDamage()
    {
        health--;

        if(health <= 2)
        {
            hearts[health].enabled = false;
            StartCoroutine(Blink());
        }
    }

    IEnumerator Blink()
    {
        for (int i = 0; i < 3; i++)
        {
            meshRenderer.enabled = false;

            yield return new WaitForSeconds(0.1f);

            meshRenderer.enabled = true;

            yield return new WaitForSeconds(0.1f);
            
        }
      
    }



}
