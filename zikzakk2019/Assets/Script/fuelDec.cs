using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class fuelDec : MonoBehaviour
{
    // public int randomFuelAvailable;
    public GameObject FuelObj;
    public GameObject WheelObj;

    void Start()
    {
        int seed = Mathf.FloorToInt(transform.position.x) + Mathf.FloorToInt(transform.position.y) + Mathf.FloorToInt(transform.position.z);
        Random.InitState(seed);

        int randomFuelAvailable = Random.Range(0, 4);

        if (randomFuelAvailable == 2)
        {
            Instantiate(FuelObj, transform.position+new Vector3(0,1,0), Quaternion.Euler(-90,0,30));
        } 
        if (randomFuelAvailable == 3)
        {
            Instantiate(WheelObj, transform.position+new Vector3(0,1,0), Quaternion.Euler(-90,0,30));
        }
        
    }
}