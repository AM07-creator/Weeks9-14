using UnityEngine;
using UnityEngine.InputSystem;

public class Aim : MonoBehaviour
{
    public float speed;
    Vector2 rotatingDirection = Vector2.zero;
    //X axis remap variable
    Vector3 zRotation = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Horizontal input from the Input Map is now the z axis
        zRotation.z = rotatingDirection.x;
		//The vector 2 has it's transform rotation changed when the Vector 2 is multiplied by the speed float and overtime
		transform.eulerAngles += zRotation * speed * Time.deltaTime;
	}
    public void OnLook(InputAction.CallbackContext context)
    {
		//Trigger the rotation of the game object with the input from the Look event in the Input System
		rotatingDirection = context.ReadValue<Vector2>();
	}
}
