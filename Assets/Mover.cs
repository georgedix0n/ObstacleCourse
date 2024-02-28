using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal")/10.0f;
        float zValue = Input.GetAxis("Vertical")/10.0f;

        transform.Translate(xValue,0.0f,zValue);
    }
}
