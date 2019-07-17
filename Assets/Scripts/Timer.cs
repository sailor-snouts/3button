using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Timer : MonoBehaviour
{

    public float seconds = 300;

    [SerializeField]
    private TextMeshProUGUI timerCountdownText;

    private bool hasEnded = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(seconds + " Is Target Time");
    }

    // Update is called once per frame
    void Update()
    {
        timerCountdownText.text = Math.Truncate(seconds - Time.timeSinceLevelLoad).ToString();
        if(Time.timeSinceLevelLoad >= seconds && !hasEnded) {
            Debug.Log("Quitting!");
            hasEnded = true;
        }
    }
}
