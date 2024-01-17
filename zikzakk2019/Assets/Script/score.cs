using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int Score;
    private int lastScoreColore;
    public Text scoreText;
    public Text highScore;

    public Color color1;
    public Color color2;
    public string startColorHex = "#FF0000"; // Başlangıç rengi hex kodu
    public string endColorHex = "#0000FF"; 

    void Start()
    {
        Score = 0;
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        //color1 = HexToColor(startColorHex);
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

    void color()
    {
        if (Score == 50)
        {
            lastScoreColore = Score;
        }
    }
}
