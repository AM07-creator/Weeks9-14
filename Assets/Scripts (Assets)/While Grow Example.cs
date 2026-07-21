using UnityEngine;

public class WhileGrowExample : MonoBehaviour
{
    public float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while(t < 1)
        {
            t += Time.deltaTime;
        }
        transform.localScale = Vector3.one;
    }
}
