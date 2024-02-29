using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotateX = 0.0f;
    [SerializeField] float rotateY = 0.5f;
    [SerializeField] float rotateZ = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(rotateX,rotateY,rotateZ);
    }
}
