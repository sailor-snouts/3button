using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class WaterPump : MonoBehaviour
{
    private Animator anim;
    private bool isOn = true;

    private void Start()
    {
        this.anim = GetComponent<Animator>();
        this.anim.SetBool("IsOn", this.isOn);
    }

    public void TurnOn()
    {
        this.isOn = true;
        this.anim.SetBool("IsOn", this.isOn);
    }

    public void TurnOff()
    {
        this.isOn = false;
        this.anim.SetBool("IsOn", this.isOn);
    }

    public bool IsOn()
    {
        return this.isOn;
    }
}
