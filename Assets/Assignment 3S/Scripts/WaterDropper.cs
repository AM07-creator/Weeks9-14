using UnityEngine;
using UnityEngine.Events;

public class WaterDropper : MonoBehaviour
{
	public GameObject playerCup; 
	public float speed = 15f;
	//Prevent multiple resets in console
	private bool hasHitPlayer = false; 
	public UnityEvent onPlayerHit;

	void Update()
	{
		// Move droplet downward constantly
		transform.position += Vector3.down * speed * Time.deltaTime;

		// Destroy off-screen
		if (transform.position.y < -8f)
			Destroy(gameObject);

		// Detect horizontal alignment with player
		if (playerCup != null && !hasHitPlayer)
		{
			float distanceX = Mathf.Abs(transform.position.x - playerCup.transform.position.x);

			// Check if water is over player
			if (distanceX < 0.5f && transform.position.y <= playerCup.transform.position.y + 0.5f)
			{
				hasHitPlayer = true;
				Debug.Log("Water Collected!");

				// Call Point Tracker Script
				ScoreTracker scoreTracker = GetComponent<ScoreTracker>();
				if (scoreTracker != null)
				{
					scoreTracker.ResetTimer();
				}

				// Destroy water on hit
				onPlayerHit.Invoke();
			}
		}
	}
}
