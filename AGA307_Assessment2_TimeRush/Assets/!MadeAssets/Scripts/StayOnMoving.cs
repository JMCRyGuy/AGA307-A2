using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnMoving : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Rigidbody rb = other.GetComponent<Rigidbody>();
            //if (rb != null)
            {
                other.transform.SetParent(transform);
            }

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Player")
            return;

        //Rigidbody rb = other.GetComponent<Rigidbody>();
        //if (rb != null)
        {
            other.transform.SetParent(null);
        }
        
    }
    
}
