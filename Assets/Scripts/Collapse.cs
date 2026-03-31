using JetBrains.Annotations;
using System.Collections;
using Unity.Cinemachine;
using UnityEngine;

public class Collapse : MonoBehaviour
{
    public Transform building;
    public AnimationCurve collapse;
    public ParticleSystem dusty;
    public AudioSource collapsing;
    public CinemachineImpulseSource shake;
    
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
            dusty.Play();
            shake.GenerateImpulse();
            if(t < 0)
            {
                collapsing.Play();
            }
            yield return null;
        }
    }
}
