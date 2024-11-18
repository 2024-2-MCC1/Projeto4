using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider Player;
    void OnTriggerEnter(Collider collision)
    {
        if (collision = Player)
        {
            
            SceneManager.LoadScene("end_scene");
        }
    }
}
