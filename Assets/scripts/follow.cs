using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class follow : MonoBehaviour
{
    // Start is called before the first frame update
    // Variables
    public float speed = 20;
    public float rotateSpeed = 10;
    private int dIrection = -1;
    public float maxDistance = 5;
    public float directionDistance = 5;
    public float targetDistance = 5;
    public float followSpeed = 11;
    public Transform Target;
    public bool aaa = true;
    public AudioSource growl;
    public AudioClip GROWL;
    public float dist;
    void Update()
    {



        
        dist = Vector3.Distance(Target.position, transform.position);
      

        if (dist > targetDistance)
        {
            if (aaa == true)
            {
                growl.PlayOneShot(GROWL);
            }
            
            if (growl.isPlaying == true)
            {
                aaa = false;
            }
            else
            {
                aaa = true;
            }
            if (!Physics.Raycast(transform.position, transform.forward, maxDistance))
            {
                
                transform.Translate(-Vector3.forward * speed * Time.smoothDeltaTime);
            }
            else
            {
               
                if (Physics.Raycast(transform.position, transform.right, directionDistance))
                {
                    dIrection = Random.Range(-1, 2);
                }
         
                if (Physics.Raycast(transform.position, -transform.right, directionDistance))
                {
                    dIrection = Random.Range(-1, 2);
                }
               
                transform.Rotate(Vector3.up, 90 * rotateSpeed * Time.smoothDeltaTime * dIrection);
            }
        }
     
        if (dist < targetDistance)
        {
            transform.LookAt(Target);
            transform.Translate(-Vector3.forward * followSpeed * Time.smoothDeltaTime);
        }

    }
     void OnTriggerEnter(Collider other)
    {
            if(other.gameObject.name == "PLAYER")
            {
            SceneManager.LoadScene("end_scene");
            }
    }

}