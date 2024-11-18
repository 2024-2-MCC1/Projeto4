using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falaspais : MonoBehaviour
{
    public AudioSource audioSource1;
    public AudioSource audioSource2;

    // Start is called before the first frame update
    void Start()
    {
       
        audioSource1 = GetComponents<AudioSource>()[0]; 
        audioSource2 = GetComponents<AudioSource>()[1]; 
    }

    void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("pai"))
        {
            
            if (audioSource1 != null)
            {
                audioSource1.Play();
            }
        }
        
        else if (collision.gameObject.CompareTag("mae"))
        {
            
            if (audioSource2 != null)
            {
                audioSource2.Play();
            }
        }
    }
}