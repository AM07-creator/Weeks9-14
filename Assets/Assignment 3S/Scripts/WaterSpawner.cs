using UnityEngine;

public class WaterSpawner : MonoBehaviour
{
	public float spawnTime = 0;
	public GameObject waterPrefab;
	float minX = -8;
	float maxX = 8;
	float y = 6f;
	float fixedZ = 0f;
	public GameObject playerCup;

	// Start is called once before the first execution of Update after the MonoBehavior is created
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		//Creates a stopwatch that counts up to 3 seconds, then causes a droplet to instantiate and restart its stopwatch at zero
		spawnTime += Time.deltaTime;
		if (spawnTime > 3)
		{
			spawnTime = 0;

			//Spawn the debris at a randomly chosen x pos
			float randomX = Random.Range(minX, maxX);
			Vector3 spawnPosition = new Vector3(randomX, y, fixedZ);

			//Call the water dropper class and create a variable. The variable instantiates the water prefab, and gets the speed variable from the water dropper script
			//Using the variable, the water can now have a random falling speed range. Also has no rotation when spawning

			GameObject water = Instantiate(waterPrefab, spawnPosition, Quaternion.identity);
			WaterDropper mover = water.GetComponent<WaterDropper>();

			mover.playerCup = playerCup; //First playerCup is the dropper scripts'
			mover.speed = Random.Range(5f, 10f);
		}
	}
}
