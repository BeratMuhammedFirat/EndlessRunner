using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
   // public PlayerController playerController;
    public TMP_Text scoreText;
    private int score = 0;

    private void Awake()
    {
        //playerController = GetComponent<PlayerController>();
    }

    void Start()
    {
        scoreText.text = $"{score}";
    }

    public void scoreArtir()
    {
        score += 1;
        scoreText.text = $"{score}";    
        /*if(score % 10 == 0)
        {
            playerController.HizArtir();
        }*/

    }   
}

