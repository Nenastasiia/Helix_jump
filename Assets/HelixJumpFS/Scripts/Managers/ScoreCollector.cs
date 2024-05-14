using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollector : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;
    [SerializeField] private int score;
    public int Score => score;
   
    [SerializeField] private int maxScore;
    public int MaxScore => maxScore;

    protected override void Awake()
    {
        base.Awake();

        LoadMaxScore();
    }
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {
            score += levelProgress.CurrentLevel;

            if (score > maxScore)
            {
                maxScore = score;
                SaveMaxScore();
            }  
        }

        if (type == SegmentType.Finish)
        {
            if (score > maxScore)
            {
                maxScore = score;   
                SaveMaxScore();
            }
        }
    }

    private void SaveMaxScore()
    {
        PlayerPrefs.SetInt("LevelProgress:Maxscore", maxScore);
    }

    private void LoadMaxScore()
    {
        maxScore = PlayerPrefs.GetInt("LevelProgress:Maxscore", 0);
    }


}
