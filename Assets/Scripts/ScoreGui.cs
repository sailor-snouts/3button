using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreGui : MonoBehaviour
{
    private Score score;

    [SerializeField]
    TextMeshProUGUI scoreText;

    private void Start()
    {
        this.score = FindObjectOfType<Score>();
    }

    private void OnGUI()
    {
        this.scoreText.SetText("{0}", this.score.GetValue());
    }
}
