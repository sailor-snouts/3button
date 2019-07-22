using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Button : MonoBehaviour
{
    private Animator anim;
    private bool isDown = false;
    private Drainage drain;

    private void Start()
    {
        this.drain = FindObjectOfType<Drainage>();
        this.anim = GetComponent<Animator>();
        this.anim.SetBool("IsDown", this.isDown);
    }

    private void Update()
    {
        this.isDown = Input.GetKey(KeyCode.LeftArrow);
        this.anim.SetBool("IsDown", this.isDown);
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.drain.StartDraining();
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            this.drain.StopDraining();
        }
    }
}
