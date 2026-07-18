using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private PlayerController playerController;
    public TMP_Text scoreText;
    public TMP_Text distanceText;
    private int score = 0;

    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
    }

    void Start()
    {
        scoreText.text = $"{score}";
    }

    private void Update()
    {
        distanceText.text = ((int)playerController.distance).ToString();
    }
    public void scoreArtir()
    {
        score += 1;
        scoreText.text = $"{score}";    
        

    }   
}

