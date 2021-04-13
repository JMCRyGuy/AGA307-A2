using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float iniTime;
    private float curTime;
    
    
    void Start()
    {
        curTime = iniTime;
    }

    // Update is called once per frame
    void Update()
    {
        curTime -= 1 * Time.deltaTime;
    }
}
