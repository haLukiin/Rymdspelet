using UnityEngine;
using TMPro;

public class EnemyScript : MonoBehaviour
{
    
    public float speed = 5f;
    private int direction;
    public int health = 100;
    public GameObject projectile;
    public float fireCooldown = 1f;
    public int currentHealth = 100;
    public int scoreValue;
    private gameScore ScoreManager;
    




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreValue = 100;
        direction = Random.Range(8, -8);
        ScoreManager = FindAnyObjectByType<gameScore>();

    }

    // Update is called once per frame
    void Update()
    {        
        transform.Translate(Vector3.down * speed * Time.deltaTime);
      
        fireCooldown -= Time.deltaTime;
        if (fireCooldown <= 0)
        {
            Instantiate(projectile, new Vector3(this.transform.position.x, this.transform.position.y + -1f, 0), this.transform.rotation);
            fireCooldown = 1f;

        }
        if (currentHealth <= 0)
        {
            FindAnyObjectByType<gameScore>().AddScore(scoreValue);
            Destroy(gameObject);
        }
        
        
        if (transform.position.y <= -10f)
        {
            transform.position = new Vector3(transform.position.x, 11f, 0);
        }


    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
       
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            playerScript Player = collision.gameObject.GetComponent<playerScript>();

            if (Player != null )
            {
                Player.TakeDamage(20);

            }
            Destroy(gameObject);

        }



    }
    /*private void OnTriggerExit2D(Collider2D other)  
    {
       
        if (other.CompareTag("Player"))
        {
           

            FindAnyObjectByType<Gamescore>().AddScore(scoreValue);
            Destroy(gameObject);    
        }
    }*/   



}