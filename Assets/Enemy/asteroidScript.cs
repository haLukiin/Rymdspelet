using UnityEngine;
using UnityEngine.SceneManagement;

public class asteroidScript : MonoBehaviour
{
    public float speed = 5f;
    private int direction;
    public float health = 10f;
    public float currentHealth = 10f;
    private gameScore ScoreManager;
    public int scoreValue = 25; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction = Random.Range(1, -1);
        ScoreManager = FindAnyObjectByType<gameScore>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);
        transform.Translate(Vector3.left * direction * speed * Time.deltaTime);

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }


        if (transform.position.y <= -10f)
        {
            transform.position = new Vector3(transform.position.x, 11f, 0);

        }

        if (currentHealth <= 0)
        {
            FindAnyObjectByType<gameScore>().AddScore(scoreValue);
            Destroy(gameObject);
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


            if (Player != null)
            {
                Player.TakeDamage(5);
            }
            Destroy(gameObject);
        



        }
    }
    
}