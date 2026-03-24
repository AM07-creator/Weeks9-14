using UnityEngine;

public class Knight : MonoBehaviour
{
    public AudioSource footstep;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Footstep()
    {
        //Debug.Log("Footstep");
        footstep.Play();
    }
}
