using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    public GameObject arrowsPrefab;
    public float duration;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(arrowsPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
