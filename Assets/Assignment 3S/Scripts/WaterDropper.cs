using UnityEngine;
using UnityEngine.Events;

public class WaterDropper : MonoBehaviour
{
	public GameObject playerCup; 
	public float speed = 15f;
	//Prevent multiple resets in console
	private bool hasHitPlayer = false; 
	public UnityEvent onPlayerHit;
	public PointTracker test;

    void Update()
	{
		// Move droplet downward constantly
		transform.position += Vector3.down * speed * Time.deltaTime;

		// Destroy off-screen
		if (transform.position.y < -8f)
		{
			Debug.Log("Water Missed! Game Over");
			test.GameOver();
            DestroyWater();

			return;
        }

		// Detect horizontal alignment with player
		if (playerCup != null && !hasHitPlayer)
		{
			float distanceX = Mathf.Abs(transform.position.x - playerCup.transform.position.x);

			// Check if water is over player
			if (distanceX < 0.5f && transform.position.y <= playerCup.transform.position.y + 0.5f)
			{
				hasHitPlayer = true;
				Debug.Log("Water Collected!");
				test.AddToScore();

				// Set water to inactive in Unity
				onPlayerHit.Invoke();
			}
		}
	}
	public void DestroyWater()
	{
		Destroy(gameObject);
	}
}
