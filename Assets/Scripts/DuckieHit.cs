using UnityEngine;

public class SoundManager : MonoBehaviour
{
	public AudioSource hitSound;

	public void PlayHitSound()
	{
		if (hitSound != null)
			hitSound.Play();
	}
}