using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.InputSystem.HID;
using UnityEngine.SceneManagement;

public class START : MonoBehaviour
{
    public bool clic_start = false;
    public bool clic_config = false;
    public bool clic_quit = false;

    public RaycastHit hit;

    public GameObject man_sit;
    public GameObject config_button;
    public GameObject config_menu;

    public float CamAxisX;
    public float CamAxisY;

    public Transform CamCenter;

    public float Mousen;


        void Update()
        {
        if (clic_config == false)
        {
        CamAxisX += (Input.GetAxis("Mouse X") * Time.deltaTime * Mousen);
        CamAxisY -= (Input.GetAxis("Mouse Y") * Time.deltaTime * Mousen);

        CamAxisY = Mathf.Clamp(CamAxisY, -90, 90);

            config_button.SetActive(false);
            config_menu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
        Ray ray = new Ray(CamCenter.position, CamCenter.forward);

        CamCenter.rotation = Quaternion.Euler(CamAxisY, CamAxisX, 0f);
        if (Input.GetMouseButton(0))
        {
            Physics.Raycast(ray, out hit, 1000f);

            if (hit.collider.gameObject.tag == "START")
            {
                clic_start = true;
            }
            if (hit.collider.gameObject.tag == "CONFIG")
            {
                clic_config = true;
            }
            if (hit.collider.gameObject.tag == "QUIT")
            {
                clic_quit = true;
            }
        }

        if (clic_start == true)
        {
            man_sit.SetActive(true);
            Invoke("DestroyMan", 0.3f);
            clic_start = false;
            Invoke("Next", 1f);

        }
        if (clic_quit == true)
        {
            Application.Quit();
        }
        if(clic_config == true)
        {
            Cursor.lockState = CursorLockMode.None;
            CamAxisY = -17f;
            CamAxisX = 520f;
            config_button.SetActive(true);
            config_menu.SetActive(true);
            if (Input.GetKey(KeyCode.Escape))
            {
                clic_config = false;
            }
        }
    }
        // ==================================================== \\
    void DestroyMan()
    {
        man_sit.SetActive(false);
    }
    void Next()
    {
        SceneManager.LoadScene("Desenho");
        SceneManager.UnloadSceneAsync("menu teste");
    }
}


