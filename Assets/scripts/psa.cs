using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class psa : MonoBehaviour
{
    // Start is called before the first frame update
    Color Trans = new Color(0, 0, 0, 1);
    bool start = true;
    void Update()
    {

        GetComponent<RawImage>().color = Trans;
        Trans.r = Mathf.Clamp(Trans.r, 0f, 1f);
        Trans.g = Mathf.Clamp(Trans.g, 0f, 1f);
        Trans.b = Mathf.Clamp(Trans.b, 0f, 1f);
        Trans.a = Mathf.Clamp(Trans.a, 0f, 1f);

        if (start == true)
        {
            if ((Trans.r < 1))
            {
                Trans.r += 0.005f;
                Trans.g += 0.005f;
                Trans.b += 0.005f;
            }
        }

        if ((Trans.r == 1))
        {
            Invoke("aha", 3f);
        }
        if (start == false)
        {
            Trans.r -= 0.005f;
            Trans.g -= 0.005f;
            Trans.b -= 0.005f;
            Trans.a -= 0.005f;
        }

    }
    void aha()
    {
        start = false;
    }
}
