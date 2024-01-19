using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelDec : MonoBehaviour
{
    private int randomFuelAvailable;
    public GameObject FuelObj;
    private Vector3 pos = new Vector3(0,5,0);
    void Start()
    {
        randomFuelAvailable = Random.Range(0, 5);

        if (randomFuelAvailable == 5)
        {
            Instantiate(FuelObj,this.transform);
            FuelObj.transform.position = pos;
        }
    }

    void Update()
    {
        
    }
}
