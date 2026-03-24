using UnityEngine;

public class LeftToRight : MonoBehaviour
{
    public float xspeed = 0.01f;
    public float yspeed = 0.01f;
    public AnimationCurve yValue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move birb
        Vector3 newPosition = transform.position;
        newPosition.x += xspeed;
        transform.position = newPosition;

        //check if birb is at edge of screenspace
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x > Screen.width)
        {
            newPosition.x = -10;
        }
        transform.position = newPosition;

        //y value of birb
        newPosition.y += yspeed;
        transform.position = newPosition;
        if (newPosition.y > 5 || newPosition.y < -5)
        {
            yspeed = yspeed * -1;
        }
    }
}
