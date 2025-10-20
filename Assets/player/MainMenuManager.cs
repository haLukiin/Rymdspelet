using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1f;
    }
    void Update()
    {

    }
    public void playGame()
    {
        Debug.Log("Play!");
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
        SceneManager.LoadScene(0);
    }

}
