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
    private Score score;

    private void Start()
    {
        this.drainage = FindObjectOfType<Drainage>();
        this.controlRodDepth = FindObjectOfType<ControlRodDepth>();
        this.controlRodTemp = FindObjectOfType<ControlRodTemperature>();
        this.waterPump = FindObjectOfType<WaterPump>();
        this.coreTemp = FindObjectOfType<CoreTemp>();
        this.energyOutput = FindObjectOfType<EnergyOutput>();
        this.score = FindObjectOfType<Score>();
        this.sceneChange = FindObjectOfType<SceneChange>();
    }

    private void Update()
    {
        float power = this.controlRodDepth.GetFill() + (100f - this.drainage.GetFill());
        float stability = this.drainage.GetFill() + this.controlRodTemp.GetFill();
        this.coreTemp.SetTemp(0);
        this.energyOutput.SetEnergy(0f);

        if(power > 95f || stability > 95f)
        {
            this.score.StopCounting();
            Debug.Log("Game Over");
            //this.sceneChange.FadeToLevel("GameOver");
        }
    }
}
