using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeterController : MonoBehaviour
{
    [SerializeField]
    private float current;

    [SerializeField]
    private float target;

    [SerializeField]
    private float tolerance;

    [SerializeField]
    private float button1;

    [SerializeField]
    private float button2;

    [SerializeField]
    private float button3;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.Q))
        {
            this.current += this.button1;
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.W))
        {
            this.current += this.button2;
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button2) || Input.GetKeyDown(KeyCode.E))
        {
            this.current += this.button3;
        }
    }

    public bool IsStable()
    {
        return Mathf.Abs(this.current - this.target) <= this.tolerance;
    }

    public float GetCurrent()
    {
        return this.current;
    }

    public float GetTarget()
    {
        return this.target;
    }

    public void SetTarget(float target)
    {
        this.target = target;
    }
}
