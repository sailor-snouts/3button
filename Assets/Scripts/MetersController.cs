using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetersController : MonoBehaviour
{
    private MeterController[] meters;

    void Start()
    {
        this.meters = GetComponentsInChildren<MeterController>();
    }
    
    void Update()
    {
        foreach(MeterController meter in this.meters)
        {
            if(!meter.IsStable())
            {
                FindObjectOfType<SceneChange>().FadeToLevel("GameOver");
            }
        }
    }
}
