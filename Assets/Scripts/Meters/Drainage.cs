using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drainage : MonoBehaviour
{
    [SerializeField]
    private Transform mask;
    
    private float fillRate = 2f;
    private float drainRate = 5f;

    private float fill = 50;
    private bool isDraining = false;

    private void Update()
    {
        if(this.isDraining)
        {
            this.fill -= this.drainRate * Time.deltaTime;
        }
        else
        {
            this.fill += this.fillRate * Time.deltaTime;
        }

        this.fill = Mathf.Clamp(this.fill, 0, 100f);

        Vector2 maskScale = new Vector3(1, 1);
        maskScale.y = Mathf.Clamp01(this.fill / 100f);
        this.mask.localScale = maskScale;
    }

    public void StartDraining()
    {
        this.isDraining = true;
    }

    public void StopDraining()
    {
        this.isDraining = false;
    }

    public float GetFill()
    {
        return this.fill;
    }
}
