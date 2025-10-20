using Unity.VisualScripting;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowGameOver()
    {
        gameOverText.SetActive(true);
        Time.timeScale = 0f;   
    }   

}
