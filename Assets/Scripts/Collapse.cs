using System.Collections;
using UnityEngine;

public class Collapse : MonoBehaviour
{
    public Transform building;
    public AnimationCurve collapse;
    void Start()
    {
        building.localScale = Vector2.one * 3;

        StartCoroutine(CollapseBuilding());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartCollapsingBuilding()
    {
        StartCoroutine(CollapseBuilding());
    }
    IEnumerator CollapseBuilding()
    {
        float t = 3;

        while (t > 0)
        {
            t -= Time.deltaTime;
            building.localScale = Vector2.one * t;
            yield return null;
        }
    }
}
