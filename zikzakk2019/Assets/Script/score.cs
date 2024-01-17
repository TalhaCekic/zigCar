using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int Score;
    public Text scoreText;
    public Text highScore;

    void Start()
    {
        Score = 0;
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    
    void Update()
    {
        scoreText.text = Score.ToString(); 

        if(Score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Score);
            highScore.text = Score.ToString();
        }
    }
}
