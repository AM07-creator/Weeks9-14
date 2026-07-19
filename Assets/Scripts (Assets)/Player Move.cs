using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    Vector2 movingDirection = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //The vector 2 is multiplied by the speed variable and overtime to equal the game object's transform position
        transform.position += (Vector3)movingDirection * speed * Time.deltaTime;
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        //Trigger the movement of the game object with the input from the player move event in the Input System
        movingDirection = context.ReadValue<Vector2>();
    }
}
