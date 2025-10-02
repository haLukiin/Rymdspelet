using UnityEngine;

public class enemybulletLogic : MonoBehaviour
{

    public float bulletSpeed = 5;
    public float damage = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, 5);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
        this.transform.rotation = Quaternion.Euler(0, 0, 180);
    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.CompareTag("Player"))
        {
            playerScript Player = Collision.gameObject.GetComponent<playerScript>();
            if (Player != null)
            {
                Player.TakeDamage(damage);

            }
            Destroy(gameObject);
        }
    }
}
