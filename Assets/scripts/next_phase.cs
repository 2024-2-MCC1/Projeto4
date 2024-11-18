using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_phase : MonoBehaviour
{
    public bool test;
    public Collider Player;
    void OnTriggerEnter(Collider collision)
    {
        if (collision = Player)
        {
            test = true;
            SceneManager.LoadScene("labirinto teste sofrimento");
        }
    }
}
