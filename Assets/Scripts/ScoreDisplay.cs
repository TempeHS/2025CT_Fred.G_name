using UnityEngine;
using TMPro; // Make sure you have TextMeshPro package installed

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Assign in Inspector

    void Update()
    {
        scoreText.text = "Score: " + ObjectMovement.score;
    }
}