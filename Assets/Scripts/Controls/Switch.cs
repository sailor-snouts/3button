using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Switch : MonoBehaviour
{
    private Animator anim;
    private bool isOn = true;
    private WaterPump WaterPump;

    private void Start()
    {
        this.anim = GetComponent<Animator>();
        this.anim.SetBool("IsOn", this.isOn);
        this.WaterPump = FindObjectOfType<WaterPump>();
        this.WaterPump.TurnOn();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.isOn = !this.isOn;
            this.anim.SetBool("IsOn", this.isOn);

            if(this.isOn)
            {
                this.WaterPump.TurnOn();
            }
            else
            {
                this.WaterPump.TurnOff();
            }
        }
    }
}
