using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    public GameObject arrowsPrefab;
    public float duration;
    float countUp = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        countUp = 0f;
        Instantiate(arrowsPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
