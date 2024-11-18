using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Monster_Total : MonoBehaviour
{
    public GameObject monster_crawl;
    public GameObject monster_run;
    public RawImage tela;

    void Start()
    {
        Invoke("Switch", 20f);
        Invoke("blackout", 19.8f);
        
    }

    void blackout()
    {
        tela.color = Color.black;
    }
    void Switch()
    {
        monster_crawl.SetActive(false);
        monster_run.SetActive(true);
        tela.color = Color.white;
    }
}
