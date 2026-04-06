using UnityEngine;

public class DebrisMover : MonoBehaviour
{
//Set debris falling speed
	public float speed = 15f;

	void Update()
	{
	//Make the debris fall downwards overtime
		transform.position += Vector3.down * speed * Time.deltaTime;

		// Destroy when y < -8
		if (transform.position.y < -8f)
		{
			Destroy(gameObject);
		}
	}
}