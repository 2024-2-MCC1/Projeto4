using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maeParada : MonoBehaviour
{
    public float tempoAntesDeInvisivel = 20f;

    
    private Renderer objetoRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
        objetoRenderer = GetComponent<Renderer>();

        
        StartCoroutine(TornarInvisivelDepoisDeTempo(tempoAntesDeInvisivel));
    }

    private IEnumerator TornarInvisivelDepoisDeTempo(float tempo)
    {
        
        yield return new WaitForSeconds(tempo);

        
        if (objetoRenderer != null)
        {
            objetoRenderer.enabled = false;
        }
    }
}