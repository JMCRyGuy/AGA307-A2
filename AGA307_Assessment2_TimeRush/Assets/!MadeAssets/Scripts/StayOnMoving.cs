using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnMoving : MonoBehaviour
{
    [SerializeField]
    private Vector3 veloc;
    void OnTriggerEnter(Collider col)
    {
        Rigidbody rb = col.GetComponent<Rigidbody>();
        if (rb != null)
        {
            col.transform.SetParent(transform);
        }
    }

    void OnTriggerExit(Collider col)
    {
        Rigidbody rb = col.GetComponent<Rigidbody>();
        if (rb != null)
        {
            col.transform.SetParent(null);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
