using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score = 0;

    void Start()
    {
        scoreText.text = $"{score}";
    }

    public void scoreArtir()
    {
        score += 1;
        scoreText.text = $"{score}";

    }




}

