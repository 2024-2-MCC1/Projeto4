
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeGen : MonoBehaviour
{
    public Transform POS;

    public Transform player;

    public GameObject a4;
    public GameObject a5;
    public GameObject a6;
    public GameObject a7;
    public GameObject a8;
    public GameObject a9;
    public GameObject a10;
    public GameObject a11;
    public GameObject a12;
    public GameObject a13;
    public GameObject a14;
    public GameObject a15;
    public GameObject a16;
    public GameObject a17;
    public GameObject a18;
    public GameObject a19;
    public GameObject a20;
    public GameObject a21;
    public GameObject a22;
    public GameObject a23;
    public GameObject a24;
    public GameObject a25;
    public GameObject a26;
    public GameObject a27;
    public GameObject a28;
    public GameObject a29;
    public GameObject a30;
    public GameObject a31;

    GameObject f1;
    GameObject f2;
    GameObject f3;
    GameObject f4;
    GameObject f5;
    GameObject f6;

    public bool lado1;
    public bool lado2;
    public bool lado3;
    public bool lado4;
    public bool lado5;
    public bool lado6;

    GameObject cima;
    GameObject baixo;
    GameObject direita;
    GameObject esquerda;
    GameObject frente;
    GameObject tras;

    public Vector3 V_cima;
    public Vector3 V_baixo;
    public Vector3 V_direita;
    public Vector3 V_esquerda;
    public Vector3 V_frente;
    public Vector3 V_tras;

    GameObject c1;

    public float rng_cima;
    public float rng_baixo;
    public float rng_direita;
    public float rng_esquerda;
    public float rng_frente;
    public float rng_tras;

    public float Tamanho;

    public LayerMask Jogador;
    
    void Start()
    {
       

        c1 = Instantiate(a31, POS.position, POS.rotation);

        Invoke("total_rng", 0f);




    }
    void Update()
    {
        if (player.position.y < 1760f)
        {
            SceneManager.LoadScene("teste de geração com quartos especiais");
        }

            if (lado1 == true)
            {
                if (Physics.CheckSphere(c1.transform.position + V_cima, Tamanho, Jogador))
                {
                    Destroy(c1.gameObject);
                    c1 = f1;
                    Destroy(f2.gameObject);
                    Destroy(f3.gameObject);
                    Destroy(f4.gameObject);
                    Destroy(f5.gameObject);
                    Destroy(f6.gameObject);
                    POS.transform.position += V_cima;
                    Invoke("total_rng", 0f);
                    lado1 = false; lado2 = false; lado3 = false; lado4 = false; lado5 = false; lado6 = false;

                }
            }
            if (lado2 == true)
            {
                if (Physics.CheckSphere(c1.transform.position + V_baixo, Tamanho, Jogador))
                {
                    Destroy(c1.gameObject);
                    c1 = f2;
                    Destroy(f1.gameObject);
                    Destroy(f3.gameObject);
                    Destroy(f4.gameObject);
                    Destroy(f5.gameObject);
                    Destroy(f6.gameObject);
                    POS.transform.position += V_baixo;
                    Invoke("total_rng", 0f);
                    lado1 = false; lado2 = false; lado3 = false; lado4 = false; lado5 = false; lado6 = false;

                }
            }
            if (lado3 == true)
            {
                if (Physics.CheckSphere(c1.transform.position + V_direita, Tamanho, Jogador))
                {
                    Destroy(c1.gameObject);
                    c1 = f3;
                    Destroy(f1.gameObject);
                    Destroy(f2.gameObject);
                    Destroy(f4.gameObject);
                    Destroy(f5.gameObject);
                    Destroy(f6.gameObject);
                    POS.transform.position += V_direita;
                    Invoke("total_rng", 0f);
                    lado1 = false; lado2 = false; lado3 = false; lado4 = false; lado5 = false; lado6 = false;

                }
            }

                    if (lado5 == true)
                    {
                        if (Physics.CheckSphere(c1.transform.position + V_esquerda, Tamanho, Jogador))
                        {
                            Destroy(c1.gameObject);
                            c1 = f4;
                            Destroy(f1.gameObject);
                            Destroy(f2.gameObject);
                            Destroy(f3.gameObject);
                            Destroy(f5.gameObject);
                            Destroy(f6.gameObject);
                            POS.transform.position += V_esquerda;
                            Invoke("total_rng", 0f);
                            lado1 = false; lado2 = false; lado3 = false; lado4 = false; lado5 = false; lado6 = false;

                        }
                    }
            

            if (lado4 == true)
            {
                if (Physics.CheckSphere(c1.transform.position + V_frente, Tamanho, Jogador))
                {
                    Destroy(c1.gameObject);
                    c1 = f5;
                    Destroy(f1.gameObject);
                    Destroy(f2.gameObject);
                    Destroy(f3.gameObject);
                    Destroy(f4.gameObject);
                    Destroy(f6.gameObject);
                    POS.transform.position += V_frente;
                    Invoke("total_rng", 0f);
                    lado1 = false; lado2 = false; lado3 = false; lado4 = false; lado5 = false; lado6 = false;

                }
            }
        if (lado6 == true)
        {
            if (Physics.CheckSphere(c1.transform.position + V_tras, Tamanho, Jogador))
            {
                Destroy(c1.gameObject);
                c1 = f6;
                Destroy(f1.gameObject);
                Destroy(f2.gameObject);
                Destroy(f3.gameObject);
                Destroy(f4.gameObject);
                Destroy(f5.gameObject);
                POS.transform.position += V_tras;
                Invoke("total_rng", 0f);
                lado1 = false; lado2 = false; lado3 = false; lado4 = false; lado5 = false; lado6 = false;

            }
        }
        
    }
    void total_rng()
    {
        rng_cima = Random.Range(1, 14);

        if (rng_cima <= 2f) { cima = a5; }
        if (rng_cima <= 3f && rng_cima > 2f) { cima = a11; }
        if (rng_cima <= 4f && rng_cima > 3f) { cima = a13; }
        if (rng_cima <= 5f && rng_cima > 4f) { cima = a16; }
        if (rng_cima <= 6f && rng_cima > 5f) { cima = a20; }
        if (rng_cima <= 7f && rng_cima > 6f) { cima = a23; }
        if (rng_cima <= 8f && rng_cima > 7f) { cima = a24; }
        if (rng_cima <= 9f && rng_cima > 8f) { cima = a25; }
        if (rng_cima <= 10f && rng_cima > 9f) { cima = a26; }
        if (rng_cima <= 11f && rng_cima > 10f) { cima = a27; }
        if (rng_cima <= 12f && rng_cima > 11f) { cima = a29; }
        if (rng_cima <= 13f && rng_cima > 12f) { cima = a30; }
        if (rng_cima <= 14f && rng_cima > 13f) { cima = a30; }

        rng_baixo = Random.Range(1, 14);

        if (rng_baixo <= 2) { baixo = a5; }
        if (rng_baixo <= 3f && rng_baixo > 2f) { baixo = a9; }
        if (rng_baixo <= 4f && rng_baixo > 3f) { baixo = a10; }
        if (rng_baixo <= 5f && rng_baixo > 4f) { baixo = a14; }
        if (rng_baixo <= 6f && rng_baixo > 5f) { baixo = a17; }
        if (rng_baixo <= 7f && rng_baixo > 6f) { baixo = a19; }
        if (rng_baixo <= 8f && rng_baixo > 7f) { baixo = a22; }
        if (rng_baixo <= 9f && rng_baixo > 8f) { baixo = a25; }
        if (rng_baixo <= 10f && rng_baixo > 9f) { baixo = a26; }
        if (rng_baixo <= 11f && rng_baixo > 10f) { baixo = a27; }
        if (rng_baixo <= 12f && rng_baixo > 11f) { baixo = a29; }
        if (rng_baixo <= 13f && rng_baixo > 12f) { baixo = a30; }
        if (rng_baixo <= 14f && rng_baixo > 13f) { baixo = a30; }

        rng_direita = Random.Range(1, 13);

        if (rng_direita <= 2f) { direita = a5; }
        if (rng_direita <= 3f && rng_direita > 2f) { direita = a6; }
        if (rng_direita <= 4f && rng_direita > 3f) { direita = a7; }
        if (rng_direita <= 5f && rng_direita > 4f) { direita = a8; }
        if (rng_direita <= 6f && rng_direita > 5f) { direita = a9; }
        if (rng_direita <= 7f && rng_direita > 6f) { direita = a18; }
        if (rng_direita <= 8f && rng_direita > 7f) { direita = a19; }
        if (rng_direita <= 9f && rng_direita > 8f) { direita = a20; }
        if (rng_direita <= 10f && rng_direita > 9f) { direita = a21; }
        if (rng_direita <= 11f && rng_direita > 10f) { direita = a24; }
        if (rng_direita <= 12f && rng_direita > 11f) { direita = a28; }
        if (rng_direita <= 13f && rng_direita > 12f) { direita = a28; }

        rng_esquerda = Random.Range(1, 13);

        if (rng_esquerda <= 2f) { esquerda = a4; }
        if (rng_esquerda <= 3f && rng_esquerda > 2f) { esquerda = a7; }
        if (rng_esquerda <= 4f && rng_esquerda > 3f) { esquerda = a8; }
        if (rng_esquerda <= 5f && rng_esquerda > 4f) { esquerda = a9; }
        if (rng_esquerda <= 6f && rng_esquerda > 5f) { esquerda = a12; }
        if (rng_esquerda <= 7f && rng_esquerda > 6f) { esquerda = a13; }
        if (rng_esquerda <= 8f && rng_esquerda > 7f) { esquerda = a14; }
        if (rng_esquerda <= 9f && rng_esquerda > 8f) { esquerda = a15; }
        if (rng_esquerda <= 10f && rng_esquerda > 9f) { esquerda = a27; }
        if (rng_esquerda <= 11f && rng_esquerda > 10f) { esquerda = a27; }
        if (rng_esquerda <= 12f && rng_esquerda > 11f) { esquerda = a27; }
        if (rng_esquerda <= 13f && rng_esquerda > 12f) { esquerda = a27; }
        if (rng_esquerda <= 14f && rng_esquerda > 13f) { esquerda = a14; }

        rng_frente = Random.Range(1, 14);

        if (rng_frente <= 2f) { frente = a4; }
        if (rng_frente <= 3f && rng_frente > 2f) { frente = a6; }
        if (rng_frente <= 4f && rng_frente > 3f) { frente = a7; }
        if (rng_frente <= 5f && rng_frente > 4f) { frente = a10; }
        if (rng_frente <= 6f && rng_frente > 5f) { frente = a11; }
        if (rng_frente <= 7f && rng_frente > 6f) { frente = a12; }
        if (rng_frente <= 8f && rng_frente > 7f) { frente = a18; }
        if (rng_frente <= 9f && rng_frente > 8f) { frente = a22; }
        if (rng_frente <= 10f && rng_frente > 9f) { frente = a23; }
        if (rng_frente <= 11f && rng_frente > 10f) { frente = a25; }
        if (rng_frente <= 12f && rng_frente > 11f) { frente = a28; }
        if (rng_frente <= 13f && rng_frente > 12f) { frente = a29; }
        if (rng_frente <= 14f && rng_frente > 13f) { frente = a29; }


        rng_tras = Random.Range(1, 14);

        if (rng_tras <= 2f) { tras = a4; }
        if (rng_tras <= 3f && rng_tras > 2f) { tras = a6; }
        if (rng_tras <= 4f && rng_tras > 3f) { tras = a8; }
        if (rng_tras <= 5f && rng_tras > 4f) { tras = a15; }
        if (rng_tras <= 6f && rng_tras > 5f) { tras = a16; }
        if (rng_tras <= 7f && rng_tras > 6f) { tras = a17; }
        if (rng_tras <= 8f && rng_tras > 7f) { tras = a21; }
        if (rng_tras <= 9f && rng_tras > 8f) { tras = a22; }
        if (rng_tras <= 10f && rng_tras > 9f) { tras = a23; }
        if (rng_tras <= 11f && rng_tras > 10f) { tras = a26; }
        if (rng_tras <= 12f && rng_tras > 11f) { tras = a28; }
        if (rng_tras <= 13f && rng_tras > 12f) { tras = a29; }
        if (rng_tras <= 14f && rng_tras > 13f) { tras = a29; }
        Invoke("Gen1", 0f);

    }
    void Gen1()
    {
        string s1 = c1.name.Substring(0, 1); if (s1 == "0") { lado1 = false; } else { lado1 = true; }
        string s2 = c1.name.Substring(1, 1); if (s2 == "0") { lado2 = false; } else { lado2 = true; }
        string s3 = c1.name.Substring(2, 1); if (s3 == "0") { lado3 = false; } else { lado3 = true; }
        string s4 = c1.name.Substring(3, 1); if (s4 == "0") { lado4 = false; } else { lado4 = true; }
        string s5 = c1.name.Substring(4, 1); if (s5 == "0") { lado5 = false; } else { lado5 = true; }
        string s6 = c1.name.Substring(5, 1); if (s6 == "0") { lado6 = false; } else { lado6 = true; }

        if (lado1 == true) { f1 = Instantiate(cima, POS.transform.position + V_cima, cima.transform.rotation); }
        if (lado2 == true) { f2 = Instantiate(baixo, POS.transform.position + V_baixo, baixo.transform.rotation); ; }
        if (lado3 == true) { f3 = Instantiate(direita, POS.transform.position + V_direita, direita.transform.rotation); }
        
 
            if (lado5 == true) { f4 = Instantiate(esquerda, POS.transform.position + V_esquerda, esquerda.transform.rotation); }

        if (lado4 == true) { f5 = Instantiate(frente, POS.transform.position + V_frente, frente.transform.rotation); }

        if (lado6 == true) { f6 = Instantiate(tras, POS.transform.position + V_tras, tras.transform.rotation); }

        
    }


}

