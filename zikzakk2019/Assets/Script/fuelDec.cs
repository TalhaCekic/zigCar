using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelDec : MonoBehaviour
{
    public int randomFuelAvailable;
    public GameObject FuelObj;
    void Start()
    {
  
        randomFuelAvailable = Random.Range(1, 2);
print(randomFuelAvailable);
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
