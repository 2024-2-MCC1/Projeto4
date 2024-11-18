using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody rb;
    public LayerMask Ground;
    public float jumpforce;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (Physics.Raycast(transform.position, Vector3.down, 10f))
            {
                rb.AddForce(Vector3.up * jumpforce);
            }
        }
    }
}
