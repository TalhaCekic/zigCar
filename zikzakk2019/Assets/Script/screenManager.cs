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

    private string soldcarString = "soldCar1";
    private string soldcarString2 = "soldCar2";
    private string soldcarString3 = "soldCar3";
    private string soldcarString4 = "soldCar4";
    private string soldcarString5 = "soldCar5";
    private string soldcarString6 = "soldCar6";
    public int soldCarInt;
    public int soldCarInt2;
    public int soldCarInt3;
    public int soldCarInt4;
    public int soldCarInt5;
    public int soldCarInt6;

    public AudioSource soundAudio;
    public Sprite activeSound;
    public Sprite deActiveSound;
    public Button soundButton;
    public bool isActiveSound;
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        soldCarInt = 1;
        soldCarInt2 = PlayerPrefs.GetInt(soldcarString2, soldCarInt2);
        soldCarInt3 = PlayerPrefs.GetInt(soldcarString3, soldCarInt3);
        soldCarInt4 = PlayerPrefs.GetInt(soldcarString4, soldCarInt4);
        soldCarInt5 = PlayerPrefs.GetInt(soldcarString5, soldCarInt5);
        soldCarInt6 = PlayerPrefs.GetInt(soldcarString6, soldCarInt6);
        /////
        //gameoverBackground = GameOverScreen.GetComponent<Animator>();
        GameOverScreen.SetActive(false);
        menu.SetActive(true);
        IngameScoreText.gameObject.SetActive(false);
        ShopUI.SetActive(false);

        soundAudio = GetComponent<AudioSource>();
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
        int pay1 = 150;
        int pay2 = 280;
        int pay3 = 350;
        int pay4 = 300;
        int pay5 = 490;
        int pay6 = 650;
        switch (value)
        {
            case 1:
                if (pay1 < score.instance.wheel)
                {
                    soldList[0].SetActive(true);
                    Buttons[0].SetActive(false);
                    car.instance.soldCar = true;
                    soldCarInt = 1;
                    score.instance.wheel -= pay1;
                }

                break;
            case 2:
                if (pay2 < score.instance.wheel)
                {
                    soldList[1].SetActive(true);
                    Buttons[1].SetActive(false);
                    car.instance.soldCar2 = true;
                    soldCarInt2 = 1;
                    PlayerPrefs.SetInt(soldcarString2, soldCarInt2);
                    PlayerPrefs.Save();
                    score.instance.wheel -= pay2;
                }
                break;
            case 3:
                if (pay3 < score.instance.wheel)
                {
                    soldList[2].SetActive(true);
                    Buttons[2].SetActive(false);
                    car.instance.soldCar3 = true;
                    soldCarInt3 = 1;
                    PlayerPrefs.SetInt(soldcarString3, soldCarInt3);
                    PlayerPrefs.Save();
                    score.instance.wheel -= pay3;
                }
                break;
            case 4:
                if (pay4 < score.instance.wheel)
                {
                    soldList[3].SetActive(true);
                    Buttons[3].SetActive(false);
                    car.instance.soldCar4 = true;
                    soldCarInt4 = 1;
                    PlayerPrefs.SetInt(soldcarString4, soldCarInt4);
                    PlayerPrefs.Save();
                    score.instance.wheel -= pay4;
                }
                break;
            case 5:
                if (pay5 < score.instance.wheel)
                {
                    soldList[4].SetActive(true);
                    Buttons[4].SetActive(false);
                    car.instance.soldCar5 = true;
                    soldCarInt5 = 1;
                    PlayerPrefs.SetInt(soldcarString5, soldCarInt5);
                    PlayerPrefs.Save();
                    score.instance.wheel -= pay5;
                }
                break;
            case 6:
                if (pay1 < score.instance.wheel)
                {
                    soldList[5].SetActive(true);
                    Buttons[5].SetActive(false);
                    car.instance.soldCar6 = true;
                    soldCarInt6 = 1;
                    PlayerPrefs.SetInt(soldcarString6, soldCarInt6);
                    PlayerPrefs.Save();
                    score.instance.wheel -= pay6;
                }
                break;
        }
    }

    public void back()
    {
        ShopUI.SetActive(false);
        menu.SetActive(true);
    }

    public void Sound()
    {
        isActiveSound = !isActiveSound;
        if (isActiveSound)
        {
            soundAudio.enabled = true;
            soundButton.image.sprite = activeSound;
        }
        else
        {
            soundAudio.enabled = false;
            soundButton.image.sprite = deActiveSound;
        }
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
        else
        {
            soldList[0].SetActive(false);
            Buttons[0].SetActive(true);
            car.instance.soldCar = false;
        }

        if (soldCarInt2 == 1)
        {
            soldList[1].SetActive(true);
            Buttons[1].SetActive(false);
            car.instance.soldCar2 = true;
        }
        else
        {
            soldList[1].SetActive(false);
            Buttons[1].SetActive(true);
            car.instance.soldCar2 = false;
        }

        if (soldCarInt3 == 1)
        {
            soldList[2].SetActive(true);
            Buttons[2].SetActive(false);
            car.instance.soldCar3 = true;
        }
        else
        {
            soldList[2].SetActive(false);
            Buttons[2].SetActive(true);
            car.instance.soldCar3 = false;
        }

        if (soldCarInt4 == 1)
        {
            soldList[3].SetActive(true);
            Buttons[3].SetActive(false);
            car.instance.soldCar4 = true;
        }
        else
        {
            soldList[3].SetActive(false);
            Buttons[3].SetActive(true);
            car.instance.soldCar4 = false;
        }

        if (soldCarInt5 == 1)
        {
            soldList[4].SetActive(true);
            Buttons[4].SetActive(false);
            car.instance.soldCar5 = true;
        }
        else
        {
            soldList[4].SetActive(false);
            Buttons[4].SetActive(true);
            car.instance.soldCar5 = false;
        }

        if (soldCarInt6 == 1)
        {
            soldList[5].SetActive(true);
            Buttons[5].SetActive(false);
            car.instance.soldCar5 = true;
        }
        else
        {
            soldList[5].SetActive(false);
            Buttons[5].SetActive(true);
            car.instance.soldCar5 = false;
        }
    }
}