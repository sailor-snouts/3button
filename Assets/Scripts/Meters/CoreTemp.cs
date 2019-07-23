using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoreTemp : MonoBehaviour
{
    [SerializeField]
    private GameObject needle;

    private float heatRate = 5f;
    private float coolRate = 10f;
    private bool isHeating = false;
    private float guage;

    private void Update()
    {
        if (this.isHeating)
        {
            this.guage += this.heatRate * Time.deltaTime;
        }
        else
        {
            this.guage -= this.coolRate * Time.deltaTime;
        }

        this.guage = Mathf.Clamp(this.guage, 0, 100f);

        float angle = (this.guage - 50f) * (80f / 50f) * -1;
        this.needle.transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public float GetValue()
    {
        return this.guage;
    }


    public void StartCooling()
    {
        this.isHeating = false;
    }

    public void StopCooling()
    {
        this.isHeating = true;
    }
}
