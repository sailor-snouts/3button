using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Score : MonoBehaviour
{
    private float score = 0;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void OnLevelWasLoaded(int level)
    {
        if (level == 1)
        {
            this.score = 0;
        }
    }

    void Update()
    {
        this.score += Time.deltaTime;
    }

    public int GetValue()
    {
        return (int) this.score;
    }
}
