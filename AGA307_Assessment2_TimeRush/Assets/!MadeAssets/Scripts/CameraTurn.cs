using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTurn : MonoBehaviour
{
    public float turnDirection;
    public GameObject cameraRef;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
             
            if (cameraRef != null)
            {
                cameraRef.GetComponent<CameraFollower>().CameraRotate(turnDirection);
            }

            


        }


    }



}
