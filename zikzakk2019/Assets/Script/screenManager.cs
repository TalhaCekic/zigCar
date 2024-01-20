using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class screenManager : MonoBehaviour
{
    public Animator gameoverBackground;
    public GameObject GameOverScreen;
    public GameObject menu;
    public GameObject ShopUI;
    public Text IngameScoreText;
    public GameObject[] soldList;
    public GameObject[] Buttons;
    
    private string soldcarString = "soldCar";
    private string soldcarString2 = "soldCar";  
    private string soldcarString3 = "soldCar";
    private string soldcarString4 = "soldCar";  
    private string soldcarString5 = "soldCar";
    private string soldcarString6 = "soldCar";
    public int soldCarInt;
    private int soldCarInt2;
    private int soldCarInt3;
    private int soldCarInt4;
    private int soldCarInt5;
    private int soldCarInt6;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        soldCarInt = PlayerPrefs.GetInt(soldcarString, soldCarInt);
        soldCarInt2 = PlayerPrefs.GetInt(soldcarString2, soldCarInt2);
        soldCarInt3 = PlayerPrefs.GetInt(soldcarString3, soldCarInt3);
        soldCarInt4 = PlayerPrefs.GetInt(soldcarString4, soldCarInt4);
        soldCarInt5 = PlayerPrefs.GetInt(soldcarString5, soldCarInt5);
        soldCarInt6 = PlayerPrefs.GetInt(soldcarString6, soldCarInt6);
        /////
        gameoverBackground = GameOverScreen.GetComponent<Animator>();
        GameOverScreen.SetActive(false);
        menu.SetActive(true);
        IngameScoreText.gameObject.SetActive(false);
        ShopUI.SetActive(false);
    }

    public void deadScreen()
    {
        Time.timeScale = 1;
        GameOverScreen.SetActive(true);
        gameoverBackground.SetBool("dead", true);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void starts()
    {   
        if (selectedCar.instance.selecetCar != null)
        {
            Time.timeScale = 1;
            carSpawn.instance.isSpawn = true;
            menu.SetActive(false);
            IngameScoreText.gameObject.SetActive(true);
        }
    }

    public void Shop()
    {
        ShopUI.SetActive(true);
        menu.SetActive(false);
    }

    public void buyCarIndex(int value)
    {
        switch (value)
        {
            case 1:
                soldList[0].SetActive(true);
                Buttons[0].SetActive(false);
                car.instance.soldCar = true;
                soldCarInt = 1;
                PlayerPrefs.SetInt(soldcarString,soldCarInt);
                break;
            case 2:
                soldList[1].SetActive(true);
                Buttons[1].SetActive(false);
                car.instance.soldCar2 = true;
                soldCarInt2 = 1;
                PlayerPrefs.SetInt(soldcarString2,soldCarInt2);
                break;
            case 3:
                soldList[2].SetActive(true);
                Buttons[2].SetActive(false);
                car.instance.soldCar3 = true;
                soldCarInt3 = 1;
                PlayerPrefs.SetInt(soldcarString3,soldCarInt3);
                break;
            case 4:
                soldList[3].SetActive(true);
                Buttons[3].SetActive(false);
                car.instance.soldCar4 = true;
                soldCarInt4 = 1;
                PlayerPrefs.SetInt(soldcarString4,soldCarInt4);
                break;
            case 5:
                soldList[4].SetActive(true);
                Buttons[4].SetActive(false);
                car.instance.soldCar5 = true;
                soldCarInt5 = 1;
                PlayerPrefs.SetInt(soldcarString5,soldCarInt5);
                break;
            case 6:
                soldList[5].SetActive(true);
                Buttons[5].SetActive(false);
                car.instance.soldCar6 = true;
                soldCarInt6 = 1;
                PlayerPrefs.SetInt(soldcarString6,soldCarInt6);
                break;
        }
        PlayerPrefs.Save();
    }

    public void back()
    {
        ShopUI.SetActive(false);
        menu.SetActive(true);
    }

    public void exit()
    {
        Application.Quit();
    }

    public void Update()
    {
        if (soldCarInt == 1)
        {
            soldList[0].SetActive(true);
            Buttons[0].SetActive(false);
            car.instance.soldCar = true;
        }
        if (soldCarInt2 == 1)
        {
            soldList[1].SetActive(true);
            Buttons[1].SetActive(false);
            car.instance.soldCar2 = true;
        }
        if (soldCarInt3 == 1)
        {
            soldList[2].SetActive(true);
            Buttons[2].SetActive(false);
            car.instance.soldCar3 = true;
        }
        if (soldCarInt4 == 1)
        {
            soldList[3].SetActive(true);
            Buttons[3].SetActive(false);
            car.instance.soldCar4 = true;
        }
        if (soldCarInt5 == 1)
        {
            soldList[3].SetActive(true);
            Buttons[3].SetActive(false);
            car.instance.soldCar5 = true;
        }
        if (soldCarInt6 == 1)
        {
            soldList[4].SetActive(true);
            Buttons[4].SetActive(false);
            car.instance.soldCar5 = true;
        }
    }
}