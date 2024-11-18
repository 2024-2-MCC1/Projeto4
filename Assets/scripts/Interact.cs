using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{

    public Camera Camera;
    public RaycastHit hit;
    public float Reach;

    public GameObject CAM;
    public GameObject Diario;
    public GameObject UI;
    public TMP_Text UI_Interact;
    public TMP_Text UI_Pensamento;

    public bool Kitchen_Sink;
    public bool Mirror;
    public bool Television;
    public bool Chair;
    public bool Refrigerator;
    public bool Stove;
    public bool Laptop;
    public bool Bed;
    public bool acessou;
    public float Scroll_Speed;


    void Start()
    {
        UI_Interact.enabled = false;
        Diario.SetActive(false);
    }
    void Update()
    {
        Debug.DrawRay(Camera.transform.position, Camera.transform.forward, Color.yellow, 100000f);

        if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit, Reach))
        {
            if (hit.transform.tag == "Kitchen_SInk")
            {
                UI_Interact.enabled = true;
                UI_Interact.text = ("Usar Pia");
                if (Input.GetButtonDown("Fire1"))
                {
                    UI_Pensamento.text = ("É alto demais para eu lavar as mãos");
                    Invoke("Kitchen_Sink_Interact", 0f);
                }
            }
            if (hit.transform.tag == "Mirror")
            {
                UI_Interact.enabled = true;
                UI_Interact.text = ("Olhar para 'aquilo'");
                if (Input.GetButtonDown("Fire1"))
                {
                    UI_Pensamento.text = ("'aquilo'");
                    Invoke("Mirror_Interact", 0f);
                }
            }
            if (hit.transform.tag == "Television")
            {
                UI_Interact.enabled = true;
                UI_Interact.text = ("Assistir Televisao");
                if (Input.GetButtonDown("Fire1"))
                {
                    UI_Pensamento.text = ("Por que lutar?");
                    Invoke("Television_Interact", 0f);
                }
            }
            if (hit.transform.tag == "Chair")
            {
                UI_Interact.enabled = true;
                UI_Interact.text = ("Sentar-se");
                if (Input.GetButtonDown("Fire1"))
                {
                    UI_Pensamento.text = ("Nao consigo subir");
                    Invoke("Chair_Interact", 0f);
                }
            }
            if (hit.transform.tag == "Refrigerator")
            {
                UI_Interact.enabled = true;
                UI_Interact.text = ("Abrir");
                if (Input.GetButtonDown("Fire1"))
                {
                    UI_Pensamento.text = ("Se eu abrir eles vão gritar...");
                    Invoke("Refrigerator_Interact", 0f);
                }
            }
            if (hit.transform.tag == "Stove")
            {
                UI_Interact.enabled = true;
                UI_Interact.text = ("Abrir");
                if (Input.GetButtonDown("Fire1"))
                {
                    UI_Pensamento.text = ("Quero dormir la dentro");
                    Invoke("Stove_Interact", 0f);
                }
            }
            if (hit.transform.tag == "Laptop")
            {
                UI_Interact.enabled = true;
                UI_Interact.text = ("Acessar Laptop");
                if (Input.GetButtonDown("Fire1"))
                {
                    if(acessou == false) 
                    {                    
                    UI_Pensamento.text = ("Eles mudaram minha senha");
                    Invoke("Laptop_Interact", 0f);
                    }
                    if(acessou == true)
                    {
                        Diario.SetActive(true);
                        GetComponent<Movement>().enabled = false;
                        CAM.GetComponent<CAMERA>().enabled = false;
                        UI.SetActive(false);
                        Cursor.lockState = CursorLockMode.Confined;
                    }
                    acessou = true;

                }
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Diario.SetActive(false);
                    GetComponent<Movement>().enabled = true;
                    CAM.GetComponent<CAMERA>().enabled = true;
                    UI.SetActive(true);
                    Cursor.lockState = CursorLockMode.Locked;
                }
            }
            if (hit.transform.tag == "Bed_Kid")
            {
                UI_Interact.enabled = true;
                UI_Interact.text = ("Voltar a Dormir");
                if (Input.GetButtonDown("Fire1"))
                {
                    UI_Pensamento.text = ("Quero Dormir mais...");
                    Invoke("Bed_Interact", 0f);
                }
            }
            if (hit.transform.tag == "Bathroom_Sink")
            {
                UI_Interact.enabled = true;
                UI_Interact.text = ("Usar Pia");
                if (Input.GetButtonDown("Fire1"))
                {
                    UI_Pensamento.text = ("É alto demais para eu lavar as mãos");
                    Invoke("Kitchen_Sink_Interact", 0f);
                }
            }
            if (hit.transform.tag == "Toilet")
            {
                UI_Interact.enabled = true;
                UI_Interact.text = ("Usar");
                UI_Pensamento.text = ("É alto demais para eu usar sozinha");
                Invoke("Kitchen_Sink_Interact", 0f);
            }
        }
        else
        {
            UI_Interact.enabled = false;
        }


    }
    void LateUpdate()
    {
        if (Kitchen_Sink == true)
        {
            if ((UI_Pensamento.rectTransform.anchoredPosition.x > -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition += Vector2.right * Scroll_Speed * Time.deltaTime;
            }
            if ((UI_Pensamento.rectTransform.anchoredPosition.x < -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition = Vector2.right * 100 + Vector2.up * 3048;
                Kitchen_Sink = false;
            }
        }
        if (Mirror == true)
        {
            if ((UI_Pensamento.rectTransform.anchoredPosition.x > -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition += Vector2.right * Scroll_Speed * Time.deltaTime;
            }
            if ((UI_Pensamento.rectTransform.anchoredPosition.x < -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition = Vector2.right * 100 + Vector2.up * 3048;
                Mirror = false;
            }
        }
        if (Television == true)
        {
            if ((UI_Pensamento.rectTransform.anchoredPosition.x > -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition += Vector2.right * Scroll_Speed * Time.deltaTime;
            }
            if ((UI_Pensamento.rectTransform.anchoredPosition.x < -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition = Vector2.right * 100 + Vector2.up * 3048;
                Television = false;
            }
        }
        if (Chair == true)
        {
            if ((UI_Pensamento.rectTransform.anchoredPosition.x > -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition += Vector2.right * Scroll_Speed * Time.deltaTime;
            }
            if ((UI_Pensamento.rectTransform.anchoredPosition.x < -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition = Vector2.right * 100 + Vector2.up * 3048;
                Chair = false;
            }
        }
        if (Stove == true)
        {
            if ((UI_Pensamento.rectTransform.anchoredPosition.x > -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition += Vector2.right * Scroll_Speed * Time.deltaTime;
            }
            if ((UI_Pensamento.rectTransform.anchoredPosition.x < -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition = Vector2.right * 100 + Vector2.up * 3048;
                Stove = false;
            }
        }
        if (Laptop == true)
        {
            if ((UI_Pensamento.rectTransform.anchoredPosition.x > -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition += Vector2.right * Scroll_Speed * Time.deltaTime;
            }
            if ((UI_Pensamento.rectTransform.anchoredPosition.x < -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition = Vector2.right * 100 + Vector2.up * 3048;
                Laptop = false;
            }
        }
        if (Bed == true)
        {
            if ((UI_Pensamento.rectTransform.anchoredPosition.x > -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition += Vector2.right * Scroll_Speed * Time.deltaTime;
            }
            if ((UI_Pensamento.rectTransform.anchoredPosition.x < -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition = Vector2.right * 100 + Vector2.up * 3048;
                Bed = false;
            }
            Invoke("Next", 2f);
        }
        if (Refrigerator == true)
        {
            if ((UI_Pensamento.rectTransform.anchoredPosition.x > -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition += Vector2.right * Scroll_Speed * Time.deltaTime;
            }
            if ((UI_Pensamento.rectTransform.anchoredPosition.x < -200))
            {
                UI_Pensamento.rectTransform.anchoredPosition = Vector2.right * 100 + Vector2.up * 3048;
                Refrigerator = false;
            }
        }


    }
    void Kitchen_Sink_Interact()
    {
        Kitchen_Sink = true;
    }
    void Mirror_Interact()
    {
        Mirror = true;
    }
    void Television_Interact()
    {
        Television = true;
    }
    void Chair_Interact()
    {
        Chair = true;
    }
    void Refrigerator_Interact()
    {
        Refrigerator = true;
    }
    void Stove_Interact()
    {
        Stove = true;
    }
    void Laptop_Interact()
    {
        Laptop = true;
    }
    void Bed_Interact()
    {
        Bed = true;
    }
    void Next()
    {

        SceneManager.LoadScene("1-2");
        SceneManager.UnloadSceneAsync("SpeedTutor Test Scene");
    }
}