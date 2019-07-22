using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using TMPro;

public class HighScoreManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoreText;

    private HighScore currentScore;
    private int currentScorePos;
    private TextAsset highscores;
    private List<HighScore> scores;

    void Start()
    {
        this.scores = new List<HighScore>();
        this.Load();
        this.Add();
        this.Save();
    }

    private void Load()
    {
        this.highscores = Resources.Load<TextAsset>("highscores");

        string[] lines = this.highscores.text.Split('\n');
        for (int i = 0; i < lines.Length; i++)
        {
            HighScore score = new HighScore();
            if (lines[i] != "")
            {
                score.score = Int32.Parse(lines[i]);
                this.scores.Add(score);
            }
        }
    }

    private void Add()
    {
        Score playerScore = FindObjectOfType<Score>();
        HighScore score = new HighScore();
        score.score = playerScore.GetValue();
        this.scores.Add(score);

        this.scores.Sort(new Comparison<HighScore>((x, y) => y.score - x.score));
        this.currentScorePos = this.scores.FindIndex(x => x.score == score.score);
    }

    private void Save()
    {
        StreamWriter writer = new StreamWriter("Assets/Resources/highscores.txt", false);
        foreach (HighScore s in this.scores)
        {
            writer.WriteLine(s.score);
        }
        writer.Close();
    }

    private void OnGUI()
    {
        int index = Mathf.Max(this.currentScorePos - 9, 0);
        int scoresDisplayed = 0;
        String text = "";

        while(scoresDisplayed < 10)
        {
            if (index < this.scores.Count)
            {
                if(index == this.currentScorePos)
                {
                    text += "<color=red>" + this.scores[index].score + "</color>\n";
                }
                else
                {
                    text += this.scores[index].score + "\n";
                }

                index++;
            }
            scoresDisplayed++;
        }

        this.scoreText.SetText(text);
    }
}
