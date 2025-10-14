using UnityEngine;
using UnityEngine.UI; 

public class playerLive : MonoBehaviour


{
    public Image[] lifeCount;
    public int maxlives = 3;
    private int currentlives;   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentlives  = maxlives;
        


    }
    public void LoseLife()
    {
        currentlives--;
        UpdateLives();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
