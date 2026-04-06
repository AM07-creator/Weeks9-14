using System.Collections;
using TMPro;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
//Declare timerText TextMeshPro variable and scoreTime float;
	public TextMeshProUGUI timerText;
	public float scoreTime = 0f;

	void Start()
	{
		//Start the coroutine
		StartCoroutine(Stopwatch());
	}
	//Coroutine Function counts up, and 
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
}
