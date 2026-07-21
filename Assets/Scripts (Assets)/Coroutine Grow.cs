using System.Collections;
using UnityEngine;

public class CoroutineGrow : MonoBehaviour
{
    public Transform appleTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Test()
    {
        Debug.Log("test");
    }
    private IEnumerator Grow()
    {
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.one * t;

            //Tell Unity to run other things rather than freezing
            yield return null;
        }

        t = 0;
        while (t < 1)
        {
            t += Time.deltaTime;
            appleTransform.localScale = Vector3.one * t;

            yield return null;
        }
    }
}
