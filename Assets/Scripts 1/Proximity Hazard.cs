using UnityEngine;
using UnityEngine.Events;

public class ProximityHazard : MonoBehaviour
{
    public SpriteRenderer playerRenderer;
    public Explorer playerExplorer;
    bool isCurrentlyOnTrap = false;
    public UnityEvent onTrapEntered;
    public UnityEvent onTrapExited;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerRenderer.bounds.Contains(transform.position) && !isCurrentlyOnTrap)
        {
            onTrapEntered.Invoke();
            isCurrentlyOnTrap = true;
        }
        if (!playerRenderer.bounds.Contains(transform.position) && isCurrentlyOnTrap)
        {
            onTrapExited.Invoke();
            isCurrentlyOnTrap = false;
        }
    }
}
