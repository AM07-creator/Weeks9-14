using UnityEngine;
using UnityEngine.Events;

public class FlyingArrows : MonoBehaviour
{
    public SpriteRenderer player;
    public Explorer explorer;
    bool arrowsHitYou = false;
    public UnityEvent onHit;
    public float speed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

		//Move arrows overtime
		Vector3 directionToMove = transform.position;
        directionToMove.x += speed * Time.deltaTime;
        transform.position = directionToMove;

        if (player.bounds.Contains(transform.position) && !arrowsHitYou)
        {
            onHit.Invoke();
            arrowsHitYou = true;
        }
    }
}
