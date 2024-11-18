using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class mirror : MonoBehaviour
{
    public Transform player_cam;

    void Update()
    {
        transform.forward = new Vector3(player_cam.forward.x, player_cam.forward.y, transform.forward.z);
    }
}
