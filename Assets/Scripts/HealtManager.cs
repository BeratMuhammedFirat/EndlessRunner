using UnityEngine;
using UnityEngine.UI;

public class HealtManager : MonoBehaviour
{
 
   
    public Image[] hearts;
    public int health = 3;
    void Start()
    {
        Debug.Log(hearts.Length);
    }

    public void TakeDamage()
    {
        health--;

        if(health <= 2)
        {
            hearts[health].enabled = false;
        }
    }

    public void PuanAl()
    {
        Debug.Log("Puan arttı");

    }
   
    
}
