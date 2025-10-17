using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class playerLive : MonoBehaviour


{
    public Image heart1;
    public Image heart2;
    public Image heart3;
    public static Image[] lifeCount;
    public int maxLives = 3;
    public int currentLives;
    public playerScript playerScript;
    public int ResetLives;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentLives = maxLives;
        





    }


    // Update is called once per frame
    void Update()
    {

    }
    public void LoseLife()
    {
       
        currentLives--;

        if (currentLives == 2)
        {
            heart3.enabled = false;
        }
        else if (currentLives == 1)
        {
            heart2.enabled = false;
        }
        else if (currentLives == 0)
        {
            heart1.enabled = false;
           
        }   




    }
}