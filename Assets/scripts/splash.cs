using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splash : MonoBehaviour
{

    public Collider Player;
    public AudioSource Splash;


    private void OnTriggerEnter(Collider other)
    {
        if (other == Player)
        {
            
            Splash.Play();
        }
    }
}

