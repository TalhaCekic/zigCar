using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class car : MonoBehaviour
{
    public Image[] cars;
    public Button LeftButton;
    public Button RightButton;
    void Start()
    {
        LeftButton.onClick.AddListener(LeftButtonClick);
        RightButton.onClick.AddListener(RightButtonClick);
    }

    void Update()
    {
        switch (selectedCar.instance.selectedCarValue)
        {
            case 1:
                cars[0].gameObject.SetActive(true);
                cars[1].gameObject.SetActive(false);
                cars[2].gameObject.SetActive(false);
                cars[3].gameObject.SetActive(false);
                cars[4].gameObject.SetActive(false);
                break;
            case 2:
                cars[0].gameObject.SetActive(false);
                cars[1].gameObject.SetActive(true);
                cars[2].gameObject.SetActive(false);
                cars[3].gameObject.SetActive(false);
                cars[4].gameObject.SetActive(false);
                break;
            case 3:
                cars[0].gameObject.SetActive(false);
                cars[1].gameObject.SetActive(false);
                cars[2].gameObject.SetActive(true);
                cars[3].gameObject.SetActive(false);
                cars[4].gameObject.SetActive(false);
                break;
            case 4:
                cars[0].gameObject.SetActive(false);
                cars[1].gameObject.SetActive(false);
                cars[2].gameObject.SetActive(false);
                cars[3].gameObject.SetActive(true);
                cars[4].gameObject.SetActive(false);
                break;
            case 5:
                cars[0].gameObject.SetActive(false);
                cars[1].gameObject.SetActive(false);
                cars[2].gameObject.SetActive(false);
                cars[3].gameObject.SetActive(false);
                cars[4].gameObject.SetActive(true);
                break;
        }
    }
    void LeftButtonClick()
    {
        // Sol butona tıklama işlemleri
        selectedCar.instance.LeftButton();
    }

    void RightButtonClick()
    {
        // Sağ butona tıklama işlemleri
        selectedCar.instance.RightButton();
    }

}
