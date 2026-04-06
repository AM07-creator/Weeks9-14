using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreTracker : MonoBehaviour
{
//Declare timerText TextMeshPro variable and scoreTime float, as well as storing the coroutine's reference
	public TextMeshProUGUI timerText;
	public float scoreTime = 0f;
	Coroutine scoreRoutine;

	void Start()
	{
		//Start the coroutine
		scoreRoutine = StartCoroutine(Stopwatch());
	}
	public void StartStopWatch()
	{
		scoreRoutine = StartCoroutine(Stopwatch());
	}
	IEnumerator Stopwatch()
	{
		while (true)
		{

			//Count up and track it on the score text in unity. Limit the visible text to only two decimal places
			scoreTime += Time.deltaTime;
			timerText.text = scoreTime.ToString("F2"); // Shows only 2 decimal places on the score UI

			yield return null;
		}
	}
	public void DuckieDead()
	{
		//Stop the coroutine if a debris is touching the player
		if (scoreRoutine != null)
		{
			StopCoroutine(scoreRoutine);
		}
		scoreTime = 0f;
		timerText.text = "0";
	}
	public void RestartGame()
	{
		//Begin the coroutine again
		scoreTime = 0f;
		timerText.text = "0";

		StartStopWatch();
	}
	public void ResetTimer()
	{
		// Stop the current coroutine if it's running
		if (scoreRoutine != null)
			StopCoroutine(scoreRoutine);

		// Reset variables
		scoreTime = 0f;
		timerText.text = "0";

		// Restart the coroutine
		scoreRoutine = StartCoroutine(Stopwatch());
	}
}
