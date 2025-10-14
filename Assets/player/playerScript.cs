using Unity.VisualScripting;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    public float playerSpeed = 5;
    public float maxHealth = 100f;
    public float currentHealth = 100f; 
    private float fireCooldown = 0.5f;
    private float fireDelay = 0f;
    private gameScore ScoreManager;    



    public GameObject projectile;
        
  // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {        
        transform.position = new Vector3(0, -4, 0);
        FindAnyObjectByType<gameScore>().ResetScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * playerSpeed * Time.deltaTime);
        }
        if (transform.position.y >= 4f)
        {
            transform.position = new Vector3(transform.position.x, 3.999f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * playerSpeed * Time.deltaTime);
        }
        if (transform.position.y <= -9f)
        {
            transform.position = new Vector3(transform.position.x, -8.999f, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {        
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }
        if (transform.position.x >= 16f)
        {
            transform.position = new Vector3(-15f, transform.position.y, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);    
        }
        if (transform.position.x <= -16f)
        {
            transform.position = new Vector3(15f, transform.position.y, 0);
        }
        fireDelay -= Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && fireDelay <= 0)
        {
            Instantiate(projectile, new Vector3(this.transform.position.x, this.transform.position.y + 1f, 0), this.transform.rotation);
            fireDelay = fireCooldown;

        }
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
    }      
}






