using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeUp : MonoBehaviour
{
    
    
    public int timeIncreaseAmount;
    public GameObject rotator;
    private bool triggered;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !triggered)
        {
            triggered = true;
            Timer.Instance.TimeIncrease(timeIncreaseAmount);
            Destroy(rotator);


        }
    }
}
