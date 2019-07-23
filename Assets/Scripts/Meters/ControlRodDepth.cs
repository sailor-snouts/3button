using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRodDepth : MonoBehaviour
{
    [SerializeField]
    private Transform mask;

    private float direction = 0f;
    private float drainRate = 5f;
    private float depth = 10;

    private void Update()
    {
        this.depth += this.drainRate * this.direction * Time.deltaTime;
        Vector2 maskScale = new Vector3(1, 1);
        maskScale.x = Mathf.Clamp01(this.depth / 100f);
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

    public float GetDepth()
    {
        return this.depth;
    }
}
