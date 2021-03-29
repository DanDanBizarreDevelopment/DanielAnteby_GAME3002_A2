using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Score Values
    public float ImpactScore = 500;
    public float ComboTime = 5f;
    public float ComboScore = 1;

    // Total Score Value
    public Text scoreText;
    float Score = 0;

    //Bash Toy or Active Bumper Hit
    public void ImpactPointHit()
    {
        //Record Points
        Score += ImpactScore * ComboScore;
        scoreText.text = " " + Score;

        //Start Combo Timer
        ComboTime -= Time.deltaTime;
        if(ComboTime > 0)
        {
            ComboScore += 1;
            ComboTime = 5f;
        }
        //Combo Time runs out
        if(ComboTime == 0)
        {
            ComboScore = 1;
            ComboTime = 5f;
        }

    }

    //Reset Combo on Flipper Contact
    public void FlipperHit()
    {
        ComboTime = 5f;
        ComboScore = 1;
    }
}
