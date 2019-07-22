using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRod : MonoBehaviour
{
    [SerializeField]
    private Transform mask;

    private float direction = 0f;
    private float drainRate = 10f;
    private float fill = 50;
    private bool isDraining = false;

    private void Update()
    {
        this.fill += this.drainRate * this.direction * Time.deltaTime;
        Vector2 maskScale = new Vector3(1, 1);
        maskScale.x = Mathf.Clamp01(this.fill / 100f);
        this.mask.localScale = maskScale;
    }

    public void IncreaseDepth()
    {
        this.direction = 1f;
    }

    public void DecreaseDepth()
    {
        this.direction = -1f;
    }

    public void PauseDepth()
    {
        this.direction = 0f;
    }

    public float GetFill()
    {
        return this.fill;
    }
}
