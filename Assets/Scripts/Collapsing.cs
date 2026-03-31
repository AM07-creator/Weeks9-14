using UnityEngine;

public class Collapsing : MonoBehaviour
{
    public SpriteRenderer buildingSR;
    public bool buildingIsCollapsing = false;
    public bool buildingHasStartedCollapsing = false;

    public AnimationCurve collapse;
    public float t = 0;
    void Start()
    {
        buildingSR.transform.localScale = Vector3.one;
    }

    // Update is called once per frame
    void Update()
    {
        if(buildingIsCollapsing)
        {
            BuildingIsCollapsing();
        }
    }
    public void BuildingIsCollapsing()
    {
        t += Time.deltaTime;
        buildingSR.transform.localScale = Vector3.zero * collapse.Evaluate(t);
        if(t < 3)
        {
            buildingIsCollapsing = false;
            buildingHasStartedCollapsing = true;
            t = 0;
        }
    }
}
