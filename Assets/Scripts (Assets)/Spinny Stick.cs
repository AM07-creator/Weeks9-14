using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpinnyStick : MonoBehaviour
{
    public AnimationCurve spin;
    public float spinDuration;
    public Coroutine spinStick;
    public GameObject attackButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		spinStick = StartCoroutine(SpinStick());
	}

    // Update is called once per frame
    void Update()
    {
        
	}
    private IEnumerator SpinStick()
    {
		attackButton.SetActive(false);
		float t = 0;

        while (t < spinDuration)
        {
            t += Time.deltaTime;
            transform.eulerAngles = Vector3.one * t/ spinDuration;

            yield return null;
        }
		attackButton.SetActive(true);
        spinStick = null;
	}
    public void OnSpin()
    {
        if (spinStick != null)
        {
            spinStick = StartCoroutine(SpinStick());
        }
	}
}
