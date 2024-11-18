using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trasiçao : MonoBehaviour
{
    Color Trans = new Color(0, 0, 0, 1);
    void Update()
    {
        GetComponent<RawImage>().color = Trans;

        Trans.r += 0.001f;
        Trans.g += 0.001f;
        Trans.b += 0.001f;
    }
}
