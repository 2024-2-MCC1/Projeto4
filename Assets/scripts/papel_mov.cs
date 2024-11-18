using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class papel_mov : MonoBehaviour
{
    public float velocidade;
    
    public Transform final_pos;

    void Update()
    {
        if (transform.position.x > final_pos.position.x)
        {
            transform.position += new Vector3 (final_pos.position.x, 0f, 0f) * velocidade;
        }
        
    }
}
