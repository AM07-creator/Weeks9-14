using UnityEngine;

public class DebrisSpawner : MonoBehaviour
{
    //Set the Debris GameObject, as well as speed variable for stopwatch. Range limit for where the Debris can spawn on x pos. Speed of falling debris

    public float spawnTime = 0;
    public GameObject debrisPrefab;
    float minX = -8;
    float maxX = 8;
    float y = 6f;
    float fixedZ = 0f;

    // Start is called once before the first execution of Update after the MonoBehavior is created
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
            Vector3 spawnPosition = new Vector3(randomX, y, fixedZ);

            //Call the DebrisMover class and create a variable. The variable instantiates the debris prefab, and gets the speed variable from the DebrisMover script. Using the variable, the debris can now have a random falling speed range
			DebrisMover d = Instantiate(debrisPrefab, spawnPosition, Quaternion.identity).GetComponent<DebrisMover>();
			d.speed = Random.Range(10f, 20f);
		}
	}
}
