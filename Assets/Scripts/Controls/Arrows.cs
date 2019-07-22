using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Arrows : MonoBehaviour
{
    private ControlRod controlRod;
    private Animator anim;
    private bool isArrowUp = false;
    private bool isArrowDown = false;

    private void Start()
    {
        this.controlRod = FindObjectOfType<ControlRod>();
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
            this.controlRod.IncreaseDepth();
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.isArrowUp = false;
            this.isArrowDown = true;
            this.controlRod.DecreaseDepth();
        }
        else
        {
            this.isArrowUp = false;
            this.isArrowDown = false;
            this.controlRod.PauseDepth();
        }

        this.anim.SetBool("IsArrowUp", this.isArrowUp);
        this.anim.SetBool("IsArrowDown", this.isArrowDown);
    }
}
