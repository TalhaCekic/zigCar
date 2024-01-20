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

    void Start()
    {
        gameoverBackground = GameOverScreen.GetComponent<Animator>();
        GameOverScreen.SetActive(false);
        menu.SetActive(true);
        IngameScoreText.gameObject.SetActive(false);
        ShopUI.SetActive(false);
    }

    public void deadScreen()
    {
        Time.timeScale = 1;
        gameObject.SetActive(true);
        gameoverBackground.SetBool("dead", true);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void start()
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
                break;
            case 2:
                soldList[1].SetActive(true);
                Buttons[1].SetActive(false);
                car.instance.soldCar2 = true;
                break;
            case 3:
                soldList[2].SetActive(true);
                Buttons[2].SetActive(false);
                car.instance.soldCar3 = true;
                break;
            case 4:
                soldList[3].SetActive(true);
                Buttons[3].SetActive(false);
                car.instance.soldCar4 = true;
                break;
            case 5:
                soldList[4].SetActive(true);
                Buttons[4].SetActive(false);
                car.instance.soldCar5 = true;
                break;
            case 6:
                soldList[5].SetActive(true);
                Buttons[5].SetActive(false);
                car.instance.soldCar6 = true;
                break;
        }
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
}