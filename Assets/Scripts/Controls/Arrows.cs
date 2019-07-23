using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Arrows : MonoBehaviour
{
    private ControlRodDepth controlRodDepth;
    private ControlRodTemperature controlRodTemp;
    private Animator anim;
    private bool isArrowUp = false;
    private bool isArrowDown = false;

    private void Start()
    {
        this.controlRodDepth = FindObjectOfType<ControlRodDepth>();
        this.controlRodTemp = FindObjectOfType<ControlRodTemperature>();
        this.anim = GetComponent<Animator>();
        this.anim.SetBool("IsArrowUp", this.isArrowUp);
        this.anim.SetBool("IsArrowDown", this.isArrowDown);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.isArrowUp = true;
            this.isArrowDown = false;
            this.controlRodDepth.IncreaseDepth();
            this.controlRodTemp.IncreaseTemp();
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.isArrowUp = false;
            this.isArrowDown = true;
            this.controlRodDepth.DecreaseDepth();
            this.controlRodTemp.DecreaseTemp();
        }
        else
        {
            this.isArrowUp = false;
            this.isArrowDown = false;
            this.controlRodDepth.PauseDepth();
            if(this.controlRodDepth.GetDepth() > 50f || this.controlRodDepth.GetDepth() < 20f)
            {
                this.controlRodTemp.IncreaseTemp();
            }
            else
            {
                this.controlRodTemp.DecreaseTemp();
            }
        }

        this.anim.SetBool("IsArrowUp", this.isArrowUp);
        this.anim.SetBool("IsArrowDown", this.isArrowDown);
    }
}
