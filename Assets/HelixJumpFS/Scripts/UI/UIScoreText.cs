using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreText : BallEvents
{
    [SerializeField] private ScoreCollector scoreCollector;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text recordScoreText;


    private void Update()
    {
        recordScoreText.text = "Record:" + scoreCollector.MaxScore.ToString();
    }
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type != SegmentType.Trap)
        {
            scoreText.text = scoreCollector.Score.ToString();
        }  
    }
}
