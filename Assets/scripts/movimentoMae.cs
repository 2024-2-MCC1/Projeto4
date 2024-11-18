using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movimentoMae : MonoBehaviour
{
    public Transform[] pontos;
    public int proximoPonto = 0;
    public float velocidade = 2;
    public float distanciaMinima = 1;
    private float tempoDecorrido = 0f;
    public float tempoDeEspera = 20f;
    private Animator animator;
    public float tempoParaTocar = 30.0f;
    private float tempoAcumulado = 0f;
    private bool somTocado = false;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
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

        if (tempoDecorrido < tempoDeEspera)
        {
            tempoDecorrido += Time.deltaTime;
            return;
        }

       
        if (proximoPonto >= pontos.Length)
        {
            
            animator.SetTrigger("final");
            return; 
        }

        if (pontos.Length == 0)
            {
                Debug.Log("indique os pontos" + this.transform.name);
                return;
            }
            if (Vector3.Distance(transform.position, pontos[proximoPonto].position) < distanciaMinima)
            {
                proximoPonto++;

            }
            Vector3 direcao = pontos[proximoPonto].position - transform.position;
            Quaternion rotacao = Quaternion.LookRotation(direcao, Vector3.up);
            transform.rotation = rotacao;
            transform.Translate(Vector3.forward * velocidade * Time.deltaTime);

        







    }

   

}
