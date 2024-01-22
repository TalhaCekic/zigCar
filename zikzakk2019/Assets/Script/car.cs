using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class car : MonoBehaviour
{
    public static car instance;
    public Image[] cars;
    public Button LeftButton;
    public Button RightButton;
    public bool soldCar;
    public bool soldCar2;
    public bool soldCar3;
    public bool soldCar4;
    public bool soldCar5;
    public bool soldCar6;

    public TMP_Text kilitliText;
    
    public GameObject LockImage;
    
   
    void Start()
    {
        instance = this;
        
        LeftButton.onClick.AddListener(LeftButtonClick);
        RightButton.onClick.AddListener(RightButtonClick);

    }

    void Update()
    {
        switch (selectedCar.instance.selectedCarValue)
        {
           
            case 1:
                if (!soldCar)
                {
                    cars[0].color = Color.gray;
                    kilitliText.text = "Locked";
                    kilitliText.color = Color.red;
                    LockImage.SetActive(true);
                }
                else
                {
                    cars[0].color = Color.white;
                    kilitliText.text = "Unlocked";
                    kilitliText.color = Color.green;
                    LockImage.SetActive(false);
                }
                cars[0].gameObject.SetActive(true);
                cars[1].gameObject.SetActive(false);
                cars[2].gameObject.SetActive(false);
                cars[3].gameObject.SetActive(false);
                cars[4].gameObject.SetActive(false);
                cars[5].gameObject.SetActive(false);
                break;
            case 2:
                if (!soldCar2)
                {
                    cars[1].color = Color.gray;
                    kilitliText.text = "Locked";
                    kilitliText.color = Color.red;
                    LockImage.SetActive(true);
                }
                else
                {
                    cars[1].color = Color.white;
                    kilitliText.text = "Unlocked";
                    kilitliText.color = Color.green;
                    LockImage.SetActive(false);
                }
                cars[0].gameObject.SetActive(false);
                cars[1].gameObject.SetActive(true);
                cars[2].gameObject.SetActive(false);
                cars[3].gameObject.SetActive(false);
                cars[4].gameObject.SetActive(false);
                cars[5].gameObject.SetActive(false);
                break;
            case 3:
                if (!soldCar3)
                {
                    cars[2].color = Color.gray;
                    kilitliText.text = "Locked";
                    kilitliText.color = Color.red;
                    LockImage.SetActive(true);
                }
                else
                {
                    cars[2].color = Color.white;
                    kilitliText.text = "Unlocked";
                    kilitliText.color = Color.green;
                    LockImage.SetActive(false);
                }
                cars[0].gameObject.SetActive(false);
                cars[1].gameObject.SetActive(false);
                cars[2].gameObject.SetActive(true);
                cars[3].gameObject.SetActive(false);
                cars[4].gameObject.SetActive(false);
                cars[5].gameObject.SetActive(false);
                break;
            case 4:
                if (!soldCar4)
                {
                    cars[3].color = Color.gray;
                    kilitliText.text = "Locked";
                    kilitliText.color = Color.red;
                    LockImage.SetActive(true);
                }
                else
                {
                    cars[3].color = Color.white;
                    kilitliText.text = "Unlocked";
                    kilitliText.color = Color.green;
                    LockImage.SetActive(false);
                }
                cars[0].gameObject.SetActive(false);
                cars[1].gameObject.SetActive(false);
                cars[2].gameObject.SetActive(false);
                cars[3].gameObject.SetActive(true);
                cars[4].gameObject.SetActive(false);
                cars[5].gameObject.SetActive(false);
                break;
            case 5:
                if (!soldCar5)
                {
                    cars[4].color = Color.gray;
                    kilitliText.text = "Locked";
                    kilitliText.color = Color.red;
                    LockImage.SetActive(true);
                }
                else
                {
                    cars[4].color = Color.white;
                    kilitliText.text = "Unlocked";
                    kilitliText.color = Color.green;
                    LockImage.SetActive(false);
                }
                cars[0].gameObject.SetActive(false);
                cars[1].gameObject.SetActive(false);
                cars[2].gameObject.SetActive(false);
                cars[3].gameObject.SetActive(false);
                cars[4].gameObject.SetActive(true);
                cars[5].gameObject.SetActive(false);
                break; 
            case 6:
                if (!soldCar6)
                {
                    cars[5].color = Color.gray;
                    kilitliText.text = "Locked";
                    kilitliText.color = Color.red;
                    LockImage.SetActive(true);
                }
                else
                {
                    cars[5].color = Color.white;
                    kilitliText.text = "Unlocked";
                    kilitliText.color = Color.green;
                    LockImage.SetActive(false);
                }
                cars[0].gameObject.SetActive(false);
                cars[1].gameObject.SetActive(false);
                cars[2].gameObject.SetActive(false);
                cars[3].gameObject.SetActive(false);
                cars[4].gameObject.SetActive(false);
                cars[5].gameObject.SetActive(true);
                break;
        } 
    }
    void LeftButtonClick()
    {
        selectedCar.instance.LeftButton();
    }

    void RightButtonClick()
    {
        selectedCar.instance.RightButton();
    }

}
