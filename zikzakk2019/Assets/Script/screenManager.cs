using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenManager : MonoBehaviour
{
    public Animator gameoverBackground;
    public GameObject GameOverScreen;
    public GameObject menu;

    void Start()
    {
        gameoverBackground = GameOverScreen.GetComponent<Animator>();
        GameOverScreen.SetActive(false);
        menu.SetActive(true);
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
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        carSpawn.instance.isSpawn = true;
        menu.SetActive(false);
    }

    // public void mainMenu()
    // {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    // }

    public void exit()
    {
        Application.Quit();
    }

    void Update()
    {
    }
}