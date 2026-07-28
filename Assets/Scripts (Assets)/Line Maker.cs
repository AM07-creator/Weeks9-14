using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class LineMaker : MonoBehaviour
{
    public float duration;
    public LineRenderer rendy;
    public Vector3 startPos;
    public Vector3 endPos;
    public Coroutine growVar;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rendy = GetComponent<LineRenderer>();
        if (rendy != null)
        {
            Debug.Log("Line maker does not have a line renderer component");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnJump(InputAction.CallbackContext context)
    {
       

        //Start growing line from left to right over an amount of time
        if (context.performed)
        {
            growVar = StartCoroutine(GrowUpdate());

            //This if statement needs to be within the other, or else the coroutine will stop when you release the space key
            if (growVar != null)
            {
                StopCoroutine(growVar);
            }
        }
    }
    IEnumerator GrowUpdate()
    {
        float t = 0;
        rendy.positionCount = 2;

        rendy.SetPosition(0, startPos);
        rendy.SetPosition(1, startPos);

        while (t < duration)
        {
            //Grow the line using a lerp
            Vector2 currentSecondPos = Vector2.Lerp(startPos, endPos, t/duration);
            rendy.SetPosition(1, currentSecondPos);


            t += Time.deltaTime;

            yield return null;
        }
    }
}
