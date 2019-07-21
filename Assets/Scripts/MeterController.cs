using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class MeterController : MonoBehaviour
{
    [SerializeField]
    private float current;

    [SerializeField]
    private float button1;

    [SerializeField]
    private float button2;

    [SerializeField]
    private float button3;

    [SerializeField]
    private float button4;

    private Animator anim;

    private void Start()
    {
        this.anim = GetComponent<Animator>();
        this.anim.SetFloat("Value", this.current);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.Q))
        {
            this.current += this.button1;
            this.anim.SetFloat("Value", this.current);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.W))
        {
            this.current += this.button2;
            this.anim.SetFloat("Value", this.current);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button2) || Input.GetKeyDown(KeyCode.E))
        {
            this.current += this.button3;
            this.anim.SetFloat("Value", this.current);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button3) || Input.GetKeyDown(KeyCode.R))
        {
            this.current += this.button4;
            this.anim.SetFloat("Value", this.current);
        }
    }

    public bool IsStable()
    {
        return Mathf.Abs(this.current) <= 10;
    }

    public float GetCurrent()
    {
        return this.current;
    }
}
