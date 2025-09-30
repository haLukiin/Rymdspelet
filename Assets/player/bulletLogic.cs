using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed = 5;
    public float damage = 10f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, 5); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime );
    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.CompareTag("Enemy"))
        {
            EnemyScript Enemy = Collision.gameObject.GetComponent<EnemyScript>();
            if (Enemy != null)
            {
                Enemy.TakeDamage(damage);

            }
            Destroy(gameObject);
        }

    }

    


}

