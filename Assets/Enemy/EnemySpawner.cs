using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public float respawnTimer;
    public Vector2 spawnPosition;
    public int enemyCounter;
    public GameObject asteroidToSpawn;
    public int asteroidCounter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StartCoroutine(SpawnerLogic());
        StartCoroutine(AsteroidLogic());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnerLogic()
    {
        while (true)
        {
            if (enemyCounter <= 10)
            {
                spawnPosition = new Vector2(Random.Range(-8, 8), 5.5f);
                respawnTimer = Random.Range(3, 4);

                Instantiate(enemyToSpawn, spawnPosition, Quaternion.identity);
                enemyCounter++;
                yield return new WaitForSeconds(respawnTimer);



            }
            yield return null;


        }

       
        

        



    }
    IEnumerator AsteroidLogic()
    {
        while (true)
        {
            if (asteroidCounter <= 10)
            {
                spawnPosition = new Vector2(Random.Range(-8, 8), 5.5f);
                respawnTimer = Random.Range(3, 4);

                Instantiate(asteroidToSpawn, spawnPosition, Quaternion.identity);
                asteroidCounter++;
                yield return new WaitForSeconds(respawnTimer);



            }
            yield return null;


        }
    }




}
    
    
       


    

