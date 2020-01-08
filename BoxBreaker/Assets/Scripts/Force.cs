using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    Rigidbody rb;



    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(0, 0, -100000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
