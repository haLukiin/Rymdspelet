using UnityEngine;
using TMPro; 
public class gameScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 
    private int score = 0;  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    {
        score = 0;
        
    }
    public void AddScore(int amount)
    {
        score += amount;
        
    }      
    private void UpdatescoreText(int score)
    {
        scoreText.text = "Score: " + score;
    }
    public void ResetScore(int reset)
    {
        score = reset;          
    }

    // Update is called once per frame
    void Update()
    {
        UpdatescoreText(score);
    }
}
