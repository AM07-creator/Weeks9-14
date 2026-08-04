using System.Collections;
using TMPro;
using UnityEngine;
public class PointTracker : MonoBehaviour
{
	//Declare timerText TextMeshPro variable and scoreTime float, as well as storing the coroutine's reference
	public TextMeshProUGUI scoreText;
	public float scoreDefault = 0f;
	Coroutine scoreRoutine;
	int howManyPoints = 0;

	void Start()
	{
		//Start the coroutine
		scoreRoutine = StartCoroutine(Stopwatch());
	}
	public void StartTracking()
	{
		scoreRoutine = StartCoroutine(Stopwatch());
	}
	IEnumerator Stopwatch()
	{
		while (true)
		{

			//While the coroutine runs, this script can track water droplets that touch the player cup according to the Water Dropper Script
			

			yield return null;
		}
	}
	public void GameOver()
	{
		//Stop the coroutine if a droplet is touching the screen's bottom edge
		if (scoreRoutine != null)
		{
			StopCoroutine(scoreRoutine);
		}
		scoreDefault = 0f;
		scoreText.text = "0";
	}
	public void RestartGame()
	{
		//Begin the coroutine again
		scoreDefault = 0f;
		scoreText.text = "0";

		StartTracking();
	}
	public void ResetScore()
	{
		// Stop the current coroutine if it's running
		if (scoreRoutine != null)
			StopCoroutine(scoreRoutine);

		// Reset variables
		scoreDefault = 0f;
		scoreText.text = "0";

		// Restart the coroutine
		scoreRoutine = StartCoroutine(Stopwatch());
	}
	//Call this function in the Water Dropper script in order to detect when a water droplet touches the player and declares a point here
	public void AddToScore()
	{
		howManyPoints += 1;
		scoreText.text = howManyPoints.ToString();
	}
}
