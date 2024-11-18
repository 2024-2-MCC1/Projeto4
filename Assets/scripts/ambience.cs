using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ambience : MonoBehaviour
{
    public GameObject multidão;
    public AudioSource rizada;
    public AudioSource multidão_SFX;
    public AudioSource radio;

    public float RNG;

    public bool test;
    // Start is called before the first frame update
    void Start()
    {
        test = false;
        Invoke("zero", 10f);
    }


    void zero()
    {
        RNG = Random.Range(0f, 27f);
        test = true;
        Invoke("um", 10f);
    }
    void um()
    {
        if (RNG <= 3f && RNG <= 1f)
        {
            multidão.gameObject.SetActive(true);
            multidão_SFX.Play();
            Invoke("mulltidão", 10f);
        }
        if (RNG <= 6f && RNG > 3f)
        {
            radio.Play();
        }
        if (RNG <= 9f && RNG > 6f)
        {
            rizada.Play();
        }
        if (RNG <= 27f && RNG > 9f)
        {
            // do nothing (place holder)
        }
        test = false;
        Invoke("zero", 10f);
    }
    ////////////////////////////////////////////////////////////////////////////////////////
    void mulltidão()
    {
        multidão.gameObject.SetActive(false);
    }


}
