using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRodTemperature : MonoBehaviour
{
    [SerializeField]
    private Transform mask;

    private float direction = 0f;
    private float drainRate = 2f;
    private float temp = 50;

    private void Update()
    {
        this.temp += this.drainRate * this.direction * Time.deltaTime;
        Vector2 maskScale = new Vector3(1, 1);
        maskScale.x = Mathf.Clamp01(this.temp / 100f);
        this.mask.localScale = maskScale;
    }

    public void IncreaseTemp()
    {
        this.direction = 1f;
    }

    public void DecreaseTemp()
    {
        this.direction = -1f;
    }

    public void PauseTemp()
    {
        this.direction = 0f;
    }

    public float GetFill()
    {
        return this.temp;
    }
}
