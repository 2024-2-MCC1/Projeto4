using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Rip_Paper : MonoBehaviour
{
    public Transform papel_1;
    public Transform papel_2;
    public float velocidade_rotação;
    public Vector3 velocidade_movimento;
    public Vector3 rotação_final1;
    public Vector3 rotação_final2;
    public GameObject Parede;
    public AudioSource rasgando;
    public AudioSource Choro;
    public AudioSource Choro1;
    public AudioSource Grito;
    Color Trans = new Color(0.23f, 0.23f, 0.23f, 1);
    public AudioSource Choro2;
    public bool fire;
    void Start()
    {
        Grito.volume = 0f;
    }
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Invoke("Fire_Vid", 4);
            rasgando.Play(0);
            Choro.PlayDelayed(2);
            Choro1.PlayDelayed(4);
            Choro2.PlayDelayed(6);
            Grito.PlayDelayed(4);
            Invoke("del_som", 3f);
            Invoke("Next", 10f);
        }

        if (Input.GetMouseButton(0))
        {
                papel_1.position -= velocidade_movimento * Time.deltaTime;
                papel_2.position += velocidade_movimento * Time.deltaTime;

                papel_1.Rotate(rotação_final1);
                papel_2.Rotate(rotação_final2);
                
                
        }

              else

              {
                    rasgando.Pause();
              }
        if (fire == true)
        {
           

            Parede.GetComponent<Renderer>().material.color = Trans;
            Trans.a -= 0.001f;
            
            Grito.volume += 0.0005f;
        }

    }

    void del_som()
    {
        rasgando.gameObject.SetActive(false);
    }

    void Fire_Vid()
    {
        fire = true;
    }
    void Next()
    {

        SceneManager.LoadScene("Apto");
        
    }



}
