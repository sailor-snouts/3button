using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoreTemp : MonoBehaviour
{
    [SerializeField]
    private GameObject needle;
    
    private float guage;

    private void Start()
    {
        this.SetTemp(0f);
    }

    public void SetTemp(float percent) 
    {
        this.guage = Mathf.Clamp(percent, 0, 100f);
        float angle = (this.guage - 50f) * (80f / 50f) * -1;
        this.needle.transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public float GetValue()
    {
        return this.guage;
    }
}
