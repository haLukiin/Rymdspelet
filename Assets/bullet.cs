using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 5); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime );
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Do stuff here

        Destroy(gameObject);
    
    
    
    }




}

