using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class penamentos_aleatorios : MonoBehaviour
{
    public float RNG_num;
    public TMP_Text UI_Pensamento;
    public float Scroll_Speed;
    public string pensamento0;
    public string pensamento1;
    public string pensamento2;
    public string pensamento3;
    public string pensamento4;
    public string pensamento5;
    public string pensamento6;
    public string pensamento7;
    public string pensamento8;
    public string pensamento9;
    public string pensamento10;

     void Start()
     {
        Invoke("RNG", 0f);
     }
    void RNG()
    {
        RNG_num = Random.Range(0, 50f);
    }
    void Update()
    {
        if ((UI_Pensamento.rectTransform.anchoredPosition.x > -200))
        {
            UI_Pensamento.rectTransform.anchoredPosition += Vector2.right * Scroll_Speed * Time.deltaTime;
        }
        if ((UI_Pensamento.rectTransform.anchoredPosition.x < -200))
        {
            UI_Pensamento.rectTransform.anchoredPosition = Vector2.right * 100 + Vector2.up * 3048;
            Invoke("RNG", 0f);
        }
        if (RNG_num > 0 && RNG_num < 1f) { UI_Pensamento.text = pensamento0; }
        if (RNG_num > 1 && RNG_num < 2f) { UI_Pensamento.text = pensamento1; }
        if (RNG_num > 2 && RNG_num < 3f) { UI_Pensamento.text = pensamento2; }
        if (RNG_num > 3 && RNG_num < 4f) { UI_Pensamento.text = pensamento3; }
        if (RNG_num > 4 && RNG_num < 5f) { UI_Pensamento.text = pensamento4; }
        if (RNG_num > 5 && RNG_num < 6f) { UI_Pensamento.text = pensamento5; }
        if (RNG_num > 6 && RNG_num < 7f) { UI_Pensamento.text = pensamento6; }
        if (RNG_num > 7 && RNG_num < 8f) { UI_Pensamento.text = pensamento7; }
        if (RNG_num > 8 && RNG_num < 9f) { UI_Pensamento.text = pensamento8; }
        if (RNG_num > 9 && RNG_num < 10f) { UI_Pensamento.text = pensamento9; }
        if (RNG_num > 10 && RNG_num < 50) { UI_Pensamento.text = pensamento10; }

    }
}
