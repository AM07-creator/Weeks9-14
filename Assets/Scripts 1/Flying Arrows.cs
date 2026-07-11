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
        Vector3 directionToMove = Vector3.zero;
        directionToMove = new Vector3(0, 0, 0);

        //Move arrows overtime
        transform.position += directionToMove * speed * Time.deltaTime;
        directionToMove.x += 3f;

        if (player.bounds.Contains(transform.position) && !arrowsHitYou)
        {
            onHit.Invoke();
            arrowsHitYou = true;
        }
    }
}
