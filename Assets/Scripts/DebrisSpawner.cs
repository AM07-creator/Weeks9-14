using UnityEngine;

public class DebrisSpawner : MonoBehaviour
{
    //Set the Debris GameObject, as well as speed variable for stopwatch. Range limit for where the Debris can spawn on x pos

    public float spawnTime = 0;
    public GameObject debrisPrefab;
    float minX = -8;
    float maxX = 8;
    float fixedY = 6f;
    float fixedZ = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Creates a stopwatch that counts up to 3 seconds, then causes a debris to instantiate and restart the stopwatch at 0
        spawnTime += Time.deltaTime;
        if (spawnTime > 3)
        {
            spawnTime = 0;
			//Spawn the debris at a randomly chosen x pos. No rotating the prefab
			float randomX = Random.Range(minX, maxX);
            Vector3 spawnPosition = new Vector3(randomX, fixedY, fixedZ);
			Instantiate(debrisPrefab, spawnPosition, Quaternion.identity);
		}
        //Destroy debris prefab at y = -6 or somewhere below the screen

        //
    }
}
