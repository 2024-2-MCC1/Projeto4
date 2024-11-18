
using Unity.VisualScripting;
using UnityEngine;


public class Movement : MonoBehaviour
{



    public Transform Body;
    float mvSpeed;
    Vector3 input;
    public Transform cam;
    public Camera Can;
    public float rotationSpeed;
    public Vector3 MoveDir;
    public Vector3 Look;
    public AudioSource step;
    public Rigidbody rb;
    public float mvRun;
    public float mvWalk;
    public bool aaa;
    
    void Start()
    {

        Application.targetFrameRate = 120;
        aaa = true;
    }   
    public void noise()
    {
        aaa = true;
    }
    void Update()
    {
        
        if ((MoveDir != Vector3.zero) && aaa == true)
        {
            Invoke("noise", 1f);
            step.Play();
            aaa = false;
            
        }

        transform.position = transform.position;
        input = new Vector3(UnityEngine.Input.GetAxis("Horizontal"), UnityEngine.Input.GetAxis("Vertical"));
        input = Vector3.ClampMagnitude(input, 1);

        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;

        Vector3 forward = cam.forward;
        Vector3 CamF = forward;
        Vector3 CamR = cam.right;
        CamF = CamF.normalized;
        CamR = CamR.normalized;
        CamF.y = 0;
        CamF.y = 0;
        Vector3 Look = new Vector3(cam.right.x, cam.forward.y);
        MoveDir = (CamF * input.y + CamR * input.x);

       transform.Translate(new Vector3((camF * input.y + camR * input.x).x, 0f, ((camF * input.y + camR * input.x).z)) * (mvSpeed));

        if (Input.GetKey(KeyCode.LeftControl))
        {
            mvSpeed = mvRun;
        }
        else
        {
            mvSpeed = mvWalk;
        }

    }
}