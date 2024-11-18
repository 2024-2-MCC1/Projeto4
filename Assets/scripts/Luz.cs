using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Luz : MonoBehaviour
{
    public GameObject Luz_Sala;
    public GameObject Luz_Cozinha;
    public GameObject Luz_Quarto1;
    public GameObject Luz_Quarto2;
    public GameObject Luz_Banheiro;
    void Start()
    {
        Luz_Sala.GetComponent<Light>().enabled = false;
        Luz_Banheiro.GetComponent<Light>().enabled = false;
        Luz_Cozinha.GetComponent<Light>().enabled = false;
        Luz_Quarto1.GetComponent<Light>().enabled = false;
        Luz_Quarto2.GetComponent<Light>().enabled = false;
}
    public void OnTriggerEnter(Collider Trigger)
    {
        if (Trigger.CompareTag("Sala_Luz")) 
        { 
            Luz_Sala.GetComponent<Light>().enabled = true;
        }
        if (Trigger.CompareTag("Cozinha_Luz"))
        {
            Luz_Cozinha.GetComponent<Light>().enabled = true;
        }
        if (Trigger.CompareTag("Quarto1_Luz"))
        {
            Luz_Quarto1.GetComponent<Light>().enabled = true;
        }
        if (Trigger.CompareTag("Quarto2_Luz"))
        {
            Luz_Quarto2.GetComponent<Light>().enabled = true;
        }
        if (Trigger.CompareTag("Banheiro_Luz"))
        {
            Luz_Banheiro.GetComponent<Light>().enabled = true;
        }
    }
    public void OnTriggerExit(Collider Trigger)
    {
        if (Trigger.CompareTag("Sala_Luz"))
        {
            Luz_Sala.GetComponent<Light>().enabled = false;
        }
        if (Trigger.CompareTag("Cozinha_Luz"))
        {
            Luz_Cozinha.GetComponent<Light>().enabled = false;
        }
        if (Trigger.CompareTag("Quarto1_Luz"))
        {
            Luz_Quarto1.GetComponent<Light>().enabled = false;
        }
        if (Trigger.CompareTag("Quarto2_Luz"))
        {
            Luz_Quarto2.GetComponent<Light>().enabled = false;
        }
        if (Trigger.CompareTag("Banheiro_Luz"))
        {
            Luz_Banheiro.GetComponent<Light>().enabled = false;
        }
    }



}
