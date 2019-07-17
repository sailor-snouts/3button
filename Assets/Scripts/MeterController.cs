using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeterController : MonoBehaviour
{
    private float current;
    private float target;
    private float button1;
    private float button2;
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


}
