using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public float seconds;

    private float targetTime;

    // Start is called before the first frame update
    void Start()
    {
        targetTime = Time.timeSinceLevelLoad + seconds;
        Debug.Log(targetTime + " Is Target Time");
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeSinceLevelLoad >= targetTime) {
            Debug.Log("Quitting!");
        }
    }
}
