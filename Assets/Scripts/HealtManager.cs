using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealtManager : MonoBehaviour
{
 
   
    public Image[] hearts;
    private MeshRenderer meshRenderer;
    public GameManager gameManager;
    public int health = 3;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        
        
    }

    public void TakeDamage()
    {
        health--;

        if(health <= 2)
        {
            hearts[health].enabled = false;
            StartCoroutine(Blink());
        }
        if (health <= 0)
        {
           gameManager.GameOver();
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
