using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class timer : MonoBehaviour
{
    public float timeRemaining;
    public TMP_Text timerDisplay;

    // Start is called before the first frame update
    void Start()
    {
        timerDisplay.text = "Time remaining: " + timeRemaining;
    }


    // Update is called once per frame
    void Update()
    {
        if (timeRemaining <= 0)
            SceneManager.LoadScene("menu");

        timeRemaining -= Time.deltaTime;

        TimeSpan t = TimeSpan.FromSeconds(timeRemaining);

        string answer = string.Format("{1:D2}m:{2:D2}s:{3:D3}",
                        t.Hours,
                        t.Minutes,
                        t.Seconds,
                        t.Milliseconds);

        timerDisplay.text = answer;
    }

    
}
