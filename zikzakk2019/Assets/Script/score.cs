using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static score instance;
    public GameObject PlayerObj;
    public static int Score;
    private int lastScoreColore;
    public Text scoreText;
    public Text highScore;

    public int lastScore;

    private int randomColorValue;
    private ColorBlock color1;
    private ColorBlock color2;
    private ColorBlock color3;   
    private ColorBlock color4;
    private ColorBlock color5;

    public int fuel;
    public int wheel;
    public TMP_Text wheelText;

    private CameraTakip _cameraTakip;
    public Slider fuelSlider;
    public Image fuelSliderImage;

    void Start()
    {
        instance = this;
        Score = 0;
        lastScoreColore = 0;
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        color1.normalColor = new Color(109 / 255f, 178 / 255f, 176 / 255f);
        color2.normalColor = new Color(255 / 255f, 240 / 255f, 144 / 255f);
        color3.normalColor = new Color(56 / 255f, 66 / 255f, 89 / 255f);
        color4.normalColor = new Color(100 / 255f, 200 / 255f, 150 / 255f);
        color5.normalColor = new Color(200 / 255f, 66 / 255f, 89 / 255f);
        
    }
    
    void Update()
    {
        scoreText.text = Score.ToString(); 

        if(Score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Score);
            highScore.text = Score.ToString();
        }

        PlayerObj = GameObject.FindWithTag("Player");
        if (PlayerObj != null)
        {
            fuelSlider.maxValue = TopMovement.instance.MaxFuel;
            fuelSlider.value = TopMovement.instance.currentFuel;
            if (TopMovement.instance.currentFuel <= TopMovement.instance.MaxFuel / 2)
            {
                fuelSliderImage.color = Color.yellow;
            }
            else if(TopMovement.instance.currentFuel <= TopMovement.instance.MaxFuel / 4)
            {
                fuelSliderImage.color = Color.red;
            }
            else
            {
                fuelSliderImage.color = Color.green;
            }
            
            PlayerPrefs.SetInt(TopMovement.instance.wheelString, TopMovement.instance.wheel);
            PlayerPrefs.Save();
        }

        if (wheelText.gameObject.activeSelf == true)
        {
          wheelText.text = TopMovement.instance.wheel.ToString();  
        }
        
        color();
        Camera.main.backgroundColor = color1.normalColor;
    }

    void color()
    {
        if (lastScore +40 == Score )
        {
            lastScore = Score;
            RandomColor();
        }
        switch (randomColorValue)
        {
            case 0:
                color1.normalColor = Color.Lerp(Camera.main.backgroundColor,color1.normalColor,Time.deltaTime);
                break;
            case 1:
                color1.normalColor = Color.Lerp(Camera.main.backgroundColor,color2.normalColor,Time.deltaTime);
                break;
            case 2:
                color1.normalColor = Color.Lerp(Camera.main.backgroundColor,color3.normalColor,Time.deltaTime);
                break;
            case 3:
                color1.normalColor = Color.Lerp(Camera.main.backgroundColor,color4.normalColor,Time.deltaTime);
                break;
            case 4:
                color1.normalColor = Color.Lerp(Camera.main.backgroundColor,color5.normalColor,Time.deltaTime);
                break;
        }
    }


    private void RandomColor()
    { 
        randomColorValue = Random.Range(1, 4);
    }
    
}
