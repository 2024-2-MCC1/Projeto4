using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class THE_END_TITLE : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    Color Trans = new Color(1, 1, 1, 1);
    void Update()
    {
        GetComponent<TextMeshProUGUI>().color = Trans;


        Trans.a -= speed;
        if (Trans.a <= 0.9647059)
        {
            Trans.a -= speed * 100;
        }

    }
}
