using UnityEngine;

public class SoundManager : MonoBehaviour
{
	public AudioSource hitSound; // assign in Inspector

	public void PlayHitSound()
	{
		if (hitSound != null)
			hitSound.Play();
	}
}