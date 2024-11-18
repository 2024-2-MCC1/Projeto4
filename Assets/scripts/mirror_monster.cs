using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirror_monster : MonoBehaviour
{
    public GameObject man_sit;
    public Transform camera_player;
    RaycastHit hit;
    Ray ray;

    void Update()
    {
        ray = new Ray(camera_player.position, camera_player.forward);
        if(Physics.Raycast(ray, out hit, 10f))
        {
            if (hit.transform.tag != "Mirror")
            {
                man_sit.SetActive(false);
            }
        }

    }
    void OnTriggerEnter(Collider other)
    {

        if (Physics.Raycast(ray, out hit, 10f))
        {
            if (hit.transform.tag == "Mirror")
            {
                man_sit.SetActive(true);
            }
        }

    }
    void OnTriggerStay(Collider other)
        {
        if (Physics.Raycast(ray, out hit, 1000f))
        {
            if (hit.transform.tag != "Mirror")
                {
                    man_sit.SetActive(false);
                }
        }


        }
    private void OnTriggerExit(Collider other)
    {
        if (Physics.Raycast(ray, out hit, 10f))
        {
            if (hit.transform.tag == "Mirror")
            {
                man_sit.SetActive(false);
            }
        }


    }
}
