using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScroll : MonoBehaviour
{

    public float scrollSpeed = 50f; // Velocidade de rolagem
    private RectTransform rectTransform;
    private float startPosition;
    public bool a;
    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        startPosition = rectTransform.anchoredPosition.x; // Posição inicial
    }

    // Update is called once per frame
    void Update()
    {
        if (a == true)
        {
            rectTransform.anchoredPosition += Vector2.right * scrollSpeed * Time.deltaTime;
            if ((rectTransform.anchoredPosition.x < -200))
            {
                rectTransform.anchoredPosition = Vector2.right * 100 + Vector2.up * 3048;
                a = false;
            }
        }


    }
}
