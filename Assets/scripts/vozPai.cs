using UnityEngine;

public class vozPai : MonoBehaviour
{
    public float tempoParaTocar = 10.0f;
    private float tempoAcumulado = 0f;
    private bool somTocado = false;
    public AudioSource audioSource;

    private float tempoParaOcultar = 40f;
    private bool objetoOculto = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        tempoAcumulado += Time.deltaTime;

        if (tempoAcumulado >= tempoParaTocar && !somTocado)
        {
            audioSource.Play();
            somTocado = true;
        }

        if (tempoAcumulado >= tempoParaOcultar && !objetoOculto)
        {
            gameObject.SetActive(false);
            objetoOculto = true;
        }
    }
}