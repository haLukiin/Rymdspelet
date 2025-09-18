using UnityEngine;

public class EnemyScript : MonoBehaviour
{
   
    public float speed = 5f;
    private int direction = Random.Range(1, -1);
    public float health = 100f;
    public GameObject projectile;
    public float fireCooldown = 1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void takeDamage(float damage)
    {
        health -= damage;
    }




}