using UnityEngine;

public class bulletLogic : MonoBehaviour
{
    public float bulletSpeed = 10;
    public int damage = 15;
   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, 5); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
        
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

        if (Collision.gameObject.CompareTag("Meteor"))
        {
           asteroidScript Meteor = Collision.gameObject.GetComponent<asteroidScript>();
           if (Meteor != null)
           {
             Meteor.TakeDamage(damage);

           }
            Destroy(gameObject);
        }

    }

    


}

