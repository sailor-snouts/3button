using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Drainage drainage;
    private ControlRod controlRod;
    private WaterPump waterPump;
    private SceneChange sceneChange;
    private Score score;

    private void Start()
    {
        this.drainage = FindObjectOfType<Drainage>();
        this.controlRod = FindObjectOfType<ControlRod>();
        this.waterPump = FindObjectOfType<WaterPump>();
        this.sceneChange = FindObjectOfType<SceneChange>();
        this.score = FindObjectOfType<Score>();
    }

    private void Update()
    {
        float power = this.controlRod.GetFill() + (100f - this.drainage.GetFill());
        float stability = this.drainage.GetFill(); // @TODO + core temp

        if(power > 95f || stability > 95f)
        {
            this.score.StopCounting();
            Debug.Log("Game Over");
            //this.sceneChange.FadeToLevel("GameOver");
        }
    }
}
