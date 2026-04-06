using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Set speed variable of player's left and right movement speed, as well as Input value Vector2 variable

    public float speed = 3;
    public Vector2 movementSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Use movementSpeed variable to move the player
        transform.position += (Vector3)movementSpeed * speed * Time.deltaTime;
    }
}
