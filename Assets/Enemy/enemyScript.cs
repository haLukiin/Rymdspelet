using UnityEngine;

public class EnemyScript : MonoBehaviour
{
   
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
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }




}