using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static Timer Instance { get; private set; }

    public GameObject timerText;
    public int iniTime;
    private int curTime;
    public bool timeInitialized;
    public bool timeStop;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    void Start()
    {
        curTime = iniTime;
        TimeUpdate();
    }

    
    void Update()
    {
        if (timeInitialized == false && curTime > 0 && !timeStop)
        {
            StartCoroutine(Countdown());
        }
        else if (curTime <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    IEnumerator Countdown()
    {
        timeInitialized = true;
        yield return new WaitForSeconds(1);
        curTime -= 1;
        TimeUpdate();
        timeInitialized = false;




    }

    public void TimeIncrease(int x)
    {
        curTime += x;
        TimeUpdate();

    }

    void TimeUpdate()
    {


        if (curTime >= 60)
        {
            int minute = curTime / 60;
            int second = curTime - 60 * minute;


            if (second < 10)
            {
                if (minute < 10)
                {
                    timerText.GetComponent<TextMeshProUGUI>().text = "0" + minute + ":0" + second;
                }
                else
                {
                    timerText.GetComponent<TextMeshProUGUI>().text = minute + ":0" + second;
                }
            }
            else
            {
                if (minute < 10)
                {
                    timerText.GetComponent<TextMeshProUGUI>().text = "0" + minute + ":" + second;
                }
                else
                {
                    timerText.GetComponent<TextMeshProUGUI>().text = minute + ":" + second;
                }
                
            }

        }
        else if (curTime < 10)
        {
            timerText.GetComponent<TextMeshProUGUI>().text = "00:0" + curTime;
        }
        else
        {
            timerText.GetComponent<TextMeshProUGUI>().text = "00:" + curTime;
        }












    }

}
