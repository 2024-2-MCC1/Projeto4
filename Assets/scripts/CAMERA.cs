using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class CAMERA : MonoBehaviour
{

    public Transform CamCenter;
    public float Mousen;

    public float CamAxisX;
    public float CamAxisY;


    public Camera Can;
    // Start is called before the first frame update
    void Start()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        CamAxisX += (Input.GetAxis("Mouse X") * Time.deltaTime * Mousen);
        CamAxisY -= (Input.GetAxis("Mouse Y") * Time.deltaTime * Mousen);
        
        CamAxisY = Mathf.Clamp(CamAxisY, -90, 90);

        CamCenter.rotation = Quaternion.Euler(CamAxisY, CamAxisX, 0f);

    }
}

