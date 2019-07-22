using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Score : MonoBehaviour
{
    private float score = 0;
    private bool isCounting;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void OnLevelWasLoaded(int level)
    {
        if (level == 2)
        {
            this.score = 0;
        }
    }

    void Update()
    {
        if(!this.isCounting)
        {
            return;
        }

        this.score += Time.deltaTime;
    }

    public void StopCounting()
    {
        this.isCounting = false;
    }

    public int GetValue()
    {
        return (int) this.score;
    }
}
