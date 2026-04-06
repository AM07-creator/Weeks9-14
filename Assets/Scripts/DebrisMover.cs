using UnityEngine;
using UnityEngine.Events;

public class DebrisMover : MonoBehaviour
{
    public GameObject player; // Assigned by spawner
    public float speed = 15f;

    private bool hasHitPlayer = false; //Prevent multiple resets in console

    public UnityEvent onPlayerHit;

    void Update()
    {
        // Move debris downward constantly
        transform.position += Vector3.down * speed * Time.deltaTime;

        // Destroy off-screen
        if (transform.position.y < -8f)
            Destroy(gameObject);

        // Detect horizontal alignment with player
        if (player != null && !hasHitPlayer)
        {
            float distanceX = Mathf.Abs(transform.position.x - player.transform.position.x);

            // Check if debris is over player and near player's Y pos
            if (distanceX < 0.5f && transform.position.y <= player.transform.position.y + 0.5f)
            {
                hasHitPlayer = true;
                Debug.Log("Debris hit player!");

				// Call ScoreTracker
				ScoreTracker scoreTracker = FindObjectOfType<ScoreTracker>();
				if (scoreTracker != null)
				{
					scoreTracker.ResetTimer();
				}

				// Destroy debris on hit
				onPlayerHit.Invoke();

				Destroy(gameObject);
            }
        }
    }
}