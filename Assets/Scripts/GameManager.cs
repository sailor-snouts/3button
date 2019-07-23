using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Drainage drainage;
    private ControlRodDepth controlRodDepth;
    private ControlRodTemperature controlRodTemp;
    private WaterPump waterPump;
    private CoreTemp coreTemp;
    private EnergyOutput energyOutput;
    private SceneChange sceneChange;

    private void Start()
    {
        this.drainage = FindObjectOfType<Drainage>();
        this.controlRodDepth = FindObjectOfType<ControlRodDepth>();
        this.controlRodTemp = FindObjectOfType<ControlRodTemperature>();
        this.waterPump = FindObjectOfType<WaterPump>();
        this.coreTemp = FindObjectOfType<CoreTemp>();
        this.energyOutput = FindObjectOfType<EnergyOutput>();
        this.sceneChange = FindObjectOfType<SceneChange>();
    }

    private void Update()
    {
        float power = this.controlRodDepth.GetDepth() * 0.2f + (100f - this.drainage.GetFill()) * 0.8f;
        float stability = this.drainage.GetFill() + this.controlRodTemp.GetFill();
        this.energyOutput.SetEnergy(power);

        if(power > 90f || power < 10f)
        {
            this.sceneChange.FadeToLevel("GameOver");
        }
    }
}
