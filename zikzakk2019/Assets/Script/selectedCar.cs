using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectedCar : MonoBehaviour
{
    public static selectedCar instance;
    public scribtableCarSelected _ScribtableCarSelected;
    public int selectedCarValue = 1;
    public string selectCarString = "selectCar";
    public GameObject selecetCar;
    private int totalSelectableCar;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }

        if (selectedCarValue == 0)
        {
            selectedCarValue = 1;
        }

        selectedCarValue = PlayerPrefs.GetInt(selectCarString, selectedCarValue);
    }

    void Update()
    {
        cars();
    }

    public void RightButton()
    {
        selectedCarValue = (selectedCarValue % _ScribtableCarSelected.Cars.Length) + 1;
        saveCar();
    }

    public void LeftButton()
    {
        // selectedCarValue = (selectedCarValue + 4) % _ScribtableCarSelected.Cars.Length + 1;
        selectedCarValue = (selectedCarValue + _ScribtableCarSelected.Cars.Length - 2) %
            _ScribtableCarSelected.Cars.Length + 1;
        saveCar();
    }

    private void saveCar()
    {
        PlayerPrefs.SetInt(selectCarString, selectedCarValue);
        PlayerPrefs.Save();
    }

    private void cars()
    {
        switch (selectedCarValue)
        {
            case 1:
                if (car.instance.soldCar)
                {
                    selecetCar = _ScribtableCarSelected.Cars[0];
                }
                else
                {
                    selecetCar = null;
                }
                break;
            case 2:
                if (car.instance.soldCar2)
                {
                    selecetCar = _ScribtableCarSelected.Cars[1];
                }
                else
                {
                    selecetCar = null;
                }
                break;
            case 3:
                if (car.instance.soldCar3)
                {
                    selecetCar = _ScribtableCarSelected.Cars[2];
                }
                else
                {
                    selecetCar = null;
                }
                break;
            case 4:
                if (car.instance.soldCar4)
                {
                    selecetCar = _ScribtableCarSelected.Cars[3];
                }
                else
                {
                    selecetCar = null;
                }
                break;
            case 5:
                if (car.instance.soldCar5)
                {
                    selecetCar = _ScribtableCarSelected.Cars[4];
                }
                else
                {
                    selecetCar = null;
                }
                break;
            case 6:
                if (car.instance.soldCar6)
                {
                    selecetCar = _ScribtableCarSelected.Cars[5];
                }
                else
                {
                    selecetCar = null;
                }
                break;
        }
    }
}