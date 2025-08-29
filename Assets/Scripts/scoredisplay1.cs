//second score display for bombs
using UnityEngine;
using TMPro; // Make sure you have TextMeshPro package installed

public class scoredisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Assign in Inspector

    void Update()
    {
        scoreText.text = "bombs: " + PlayerMovement.bombs;
        //PlayerMovement.bombs;
    }
}