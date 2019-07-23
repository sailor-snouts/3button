using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Switch : MonoBehaviour
{
    private Animator anim;
    private bool isOn = false;
    private WaterPump WaterPump;
    private CoreTemp coreTemp;

    private void Start()
    {
        this.anim = GetComponent<Animator>();
        this.anim.SetBool("IsOn", this.isOn);
        this.WaterPump = FindObjectOfType<WaterPump>();
        this.WaterPump.TurnOff();
        this.coreTemp = FindObjectOfType<CoreTemp>();
        this.coreTemp.StopCooling();
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
                this.coreTemp.StartCooling();
            }
            else
            {
                this.WaterPump.TurnOff();
                this.coreTemp.StopCooling();
            }
        }
    }
}
