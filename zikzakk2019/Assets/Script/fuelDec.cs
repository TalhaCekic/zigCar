using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelDec : MonoBehaviour
{
    public int randomFuelAvailable;
    public GameObject FuelObj;
    void Start()
    {
  
        randomFuelAvailable = Random.Range(0, 2);
        if (randomFuelAvailable == 2)
        {
            FuelObj.SetActive(true);
        }
        else
        {
            FuelObj.SetActive(false);
        }
    }
    
}
