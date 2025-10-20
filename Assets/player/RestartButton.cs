using UnityEngine;
using UnityEngine.SceneManagement;     
public class RestartButton : MonoBehaviour
{
    public void RestartGame()
    {
        Time.timeScale = 1f; // Resume the game if it was paused    
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene     
    }
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
