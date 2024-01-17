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

    // Update is called once per frame
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
        selectedCarValue = (selectedCarValue + 4) % _ScribtableCarSelected.Cars.Length + 1;
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
                selecetCar = _ScribtableCarSelected.Cars[0];
                break; 
            case 2:
                selecetCar = _ScribtableCarSelected.Cars[1];
                break; 
            case 3:
                selecetCar = _ScribtableCarSelected.Cars[2];
                break; 
            case 4:
                selecetCar = _ScribtableCarSelected.Cars[3];
                break;
            case 5:
                selecetCar = _ScribtableCarSelected.Cars[4];
                break;
        }
    }
}