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
    private playerScript playerScript;
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


        lifeCount[1].GetComponent<Image>().sprite = null;



    }
}