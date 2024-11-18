using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMaeAndando : MonoBehaviour
{
    public float tempoInvisibilidade = 20f;

    private Renderer objectRenderer;

    // Start is called before the first frame update
    void Start()
    {
       
        objectRenderer = GetComponent<Renderer>();

        
        SetVisibilidade(false);

       
        StartCoroutine(FicarVisivel(tempoInvisibilidade));
    }

    private void SetVisibilidade(bool visivel)
    {
        if (objectRenderer != null)
        {
            objectRenderer.enabled = visivel;
        }
    }

    private System.Collections.IEnumerator FicarVisivel(float delay)
    {
        
        yield return new WaitForSeconds(delay);

        
        SetVisibilidade(true);
    }
}