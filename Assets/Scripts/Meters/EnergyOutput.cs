using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyOutput : MonoBehaviour
{
    [SerializeField]
    private GameObject needle;
    
    private float guage;

    private void Start()
    {
        this.SetEnergy(50f);
    }

    public void SetEnergy(float percent)
    {
        this.guage = Mathf.Clamp(percent, 0, 100f);
        float angle = (this.guage - 50f) * (80f / 50f) * -1;
        this.needle.transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public float GetValue()
    {
        return this.guage;
    }
}
