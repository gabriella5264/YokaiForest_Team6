using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;

    void OnTriggerEnter(Collider other)
    {
        //thePlayer.transform.position = teleportTarget.transform.position;
        thePlayer.transform.position = new Vector3(-25, 0, 0);
    }

}
