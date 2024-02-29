using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer; 
    Rigidbody rigidbody;
    [SerializeField] float TimeToWait = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Time.time > TimeToWait)
        {   
            Debug.Log("going thru here");
            renderer.enabled = true;
            rigidbody.useGravity = true;
            
        }
    }
}
