using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPaiAndando : MonoBehaviour
{
    public float invisibilityDuration = 40f;

    private Renderer objectRenderer;

    void Start()
    {
        // Obtém o componente Renderer do objeto
        objectRenderer = GetComponent<Renderer>();

        // Torna o objeto invisível
        SetVisibility(false);

        // Inicia a corrotina para tornar o objeto visível após o tempo definido
        StartCoroutine(BecomeVisibleAfterDelay(invisibilityDuration));
    }

    private void SetVisibility(bool isVisible)
    {
        if (objectRenderer != null)
        {
            objectRenderer.enabled = isVisible;
        }
    }

    private System.Collections.IEnumerator BecomeVisibleAfterDelay(float delay)
    {
        // Espera pelo tempo definido
        yield return new WaitForSeconds(delay);

        // Torna o objeto visível
        SetVisibility(true);
    }
}