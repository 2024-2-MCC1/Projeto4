using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volume : MonoBehaviour
{
    // Start is called before the first frame update
    public void AdjustVolume(float newVolume)
    {
        AudioListener.volume = newVolume;
    }
}
