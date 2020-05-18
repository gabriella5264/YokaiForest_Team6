using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Make the game run as fast as possible
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 90;
    }

    void Update()
    {
        Application.targetFrameRate = 90;
    }
}
