using UnityEngine;

public class DuckieHit : MonoBehaviour
{
	public AudioSource hitSound;
	public void PlayHitSound()
	{
		if (hitSound != null)
			hitSound.Play();
	}
}