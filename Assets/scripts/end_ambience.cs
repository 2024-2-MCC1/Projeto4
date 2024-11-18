using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class end_ambience : MonoBehaviour
{
    public float speed;
    Color Trans = new Color(0, 0, 0, 1);
    void Update()
    {
        GetComponent<RawImage>().color = Trans;


        Trans.a -= speed;
        if (Trans.a <= 0.9647059)
        {
            Trans.a -= speed * 100;
        }
        
    }
}
