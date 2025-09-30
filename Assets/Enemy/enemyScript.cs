using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject Collision;
    public float speed = 5f;
    private int direction;
    public float health = 100f;
    public GameObject projectile;
    public float fireCooldown = 1f;

    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

      direction = Random.Range(1, -1);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * direction * speed * Time.deltaTime);
        fireCooldown -= Time.deltaTime;
        if (fireCooldown <= 0)
        {
            Instantiate(projectile, new Vector3(this.transform.position.x, this.transform.position.y + -1f, 0), this.transform.rotation);
            fireCooldown = 1f;

        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
 
            Debug.Log("Enemy crashed into the player");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }


    }



}